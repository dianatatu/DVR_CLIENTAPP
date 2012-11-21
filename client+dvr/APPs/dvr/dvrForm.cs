using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.InteropServices;

namespace dvrAPP
{
    public partial class dvrForm : Form
    {
        public IntPtr dvr;
        public const int port = 20248;  
        public bool readyToListen = false;
        public bool bw = false;
        
        public dvrForm()
        {
            InitializeComponent();
        }

        #region internal_events

        private void Form1_Load(object sender, EventArgs e)
        {
            // set maximum values in ComboBox
            String[] max_values = new String[] { "  500", "1500", "2000", "2500", "3000", "3500", "4000", "4500", "5000" };
            comboMaxim.Items.AddRange(max_values);

            dvr = createDVR();
            readyToListen = true;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textInput.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textOutput.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {

            if ((textCurrent.Text == "") || (comboMaxim.SelectedIndex == -1) || (textPercent.Text == ""))
                MessageBox.Show("Please make sure you have selected all parameters.");
            else
            {                
                // read & process images
                String[] CamFolders = Directory.GetDirectories(textInput.Text);

                Work[] ws = new Work[CamFolders.Length];
                ThreadStart[] threadArray = new ThreadStart[CamFolders.Length];
                Thread[] newThread = new Thread[CamFolders.Length];

                /*
                for (int i = 0; i < CamFolders.Length; i++)
                {
                    ws[i] = new Work();
                    threadArray[i] = new ThreadStart(ws[i].DoWork);
                    newThread[i] = new Thread(threadArray[i]);
                }
                 * */

                for (int cam = 0; cam < CamFolders.Length; cam++)
                {
                    //Work w = new Work();
                    ws[cam] = new Work();
                    ws[cam].bwCam = GetBW(dvr, cam.ToString().ToCharArray());
                    ws[cam].CamFolders = CamFolders;
                    ws[cam].cam = cam;
                    ws[cam].textOutput = textOutput.Text;
                    ws[cam].dvr = dvr;
                    ws[cam].resX = getResX(dvr, cam);
                    ws[cam].resY = getResY(dvr, cam);
                    ws[cam].bwCam = GetBW(dvr, cam.ToString().ToCharArray());
                    ws[cam].bw = bw;
                    
                    //ThreadStart threadDelegate = new ThreadStart(w.DoWork);
                    threadArray[cam] = new ThreadStart(ws[cam].DoWork);
                    //Thread newThread = new Thread(threadDelegate);
                    newThread[cam] = new Thread(threadArray[cam]);
                    //newThread.Start();
                    //newThread.Join();
                    newThread[cam].Start();
                }

                for (int i=0; i<CamFolders.Length; i++)
                    newThread[i].Join();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            processButton.Enabled = true;
        }

        private void timerRecv_Tick(object sender, EventArgs e)
        {
            if (readyToListen == true)
            {
                Listen(dvr, port);

                for (int i = 0; i < 16; i++)
                {
                    RecvResCam(dvr, i);
                    RecvBWCam(dvr);
                }

                for (int i = 0; i < 16; i++)
                    textBox1.Text += getResX(dvr, i) + " x " + getResY(dvr, i) + "; " + GetBW(dvr, i.ToString().ToCharArray())+ " \r\n";
                
                CloseConnection(dvr);

                readyToListen = false;
            }
        }
    
        private void timerWarning_Tick(object sender, EventArgs e)
        {
            if (textCurrent.Text.Length > 0 && comboMaxim.SelectedIndex != -1)
            {
                if (int.Parse(textCurrent.Text) > int.Parse(comboMaxim.SelectedItem.ToString()))
                {
                    labelWarning.Visible = true;
                    buttonBW.Enabled = false;
                }
                else
                {
                    labelWarning.Visible = false;
                    buttonBW.Enabled = true;
                }
            }
            else
                buttonBW.Enabled = false;
        }

        private void buttonBW_Click(object sender, EventArgs e)
        {
            string result = (float.Parse(textCurrent.Text.ToString()) / float.Parse(comboMaxim.Text.ToString()) * 100).ToString();
            if (result.Length > 5)
                textPercent.Text = result.Substring(0, 5);
            else
                textPercent.Text = result;
            if (float.Parse(textPercent.Text) > 70)
            {
                labelNoBW.Visible = false;
                labelYesBW.Visible = true;
                bw = true;
            }
            else
            {
                labelNoBW.Visible = true;
                labelYesBW.Visible = false;
                bw = false;
            }

            timerRecv.Enabled = true;
        }

        #endregion
    }

    public class Work
    {
        [DllImport("dvr.dll")]
        public static extern IntPtr GetImage(IntPtr ptr, char[] filePath);

        [DllImport("dvr.dll")]
        public static extern bool Process(IntPtr ptr, IntPtr image, char[] inputPath, char[] outputPath, int height, int width, bool bw);

        public String[] CamFolders;
        public int cam;
        public string textOutput;
        public IntPtr dvr;
        public int resX;
        public int resY;
        public bool bwCam;
        public bool bw;

        public void DoWork()
        {
            // create output folder for each camera
            string[] splits = CamFolders[cam].Split('\\');
            String outputPath = textOutput + "\\" + splits[splits.Length - 1];
            Console.WriteLine("=> " + outputPath);
            Directory.CreateDirectory(outputPath);

            String[] filePaths = Directory.GetFiles(CamFolders[cam].ToString());

            foreach (string img in filePaths)
            {
                Console.WriteLine(img);
                IntPtr image = GetImage(dvr, img.ToCharArray());
                splits = img.Split('\\');
                String output = outputPath + "\\" + splits[splits.Length - 1];
                Console.WriteLine(output);
                Console.WriteLine(resX.ToString() + " x " + resY.ToString());
                if (resX != -1)
                    Console.WriteLine(Process(dvr, image, img.ToCharArray(), output.ToCharArray(), resY, resX, bw || bwCam));
            }

            Console.WriteLine("=====>>> GATA <<<=====");
        }
    }
    
}


