using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

namespace dvrClient
{
    public partial class clientForm : Form
    {
        public IntPtr client;
        public int resX, resY;
        int[] resCamX = new int[16];
        int[] resCamY = new int[16];
        
        public clientForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = createClient();

            // set monitor resolution
            String[] resolution_values = new String[] { "704 x 576"};
            comboResMonitor.Items.AddRange(resolution_values);

            for (int i = 0; i < 16; i++)
            {
                SetResCamX(client, i, -1);
                SetResCamY(client, i, -1);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (comboResMonitor.SelectedIndex != -1)
            {
                //char[] delimiters = new char[] { ' ', 'x' };
                Console.WriteLine("< connect() >");

                Connect(client);
                for (int i = 0; i < 16; i++)
                {
                    // send resolution
                    SendRes(client, GetResY(client, i), GetResX(client, i), i);
                    
                    int b = 0;
                    if (getBW(i) == true)
                        b = 1;
                    else
                        b = 0;

                    //send bw
                    SendBWCam(client, b, i);
                }
                CloseConnection(client);
                
                Console.WriteLine("</ connect() >");

                buttonSend.Enabled = false;
            }
        }

        private void comboRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            char[] delimiters = new char[] { ' ', 'x' };
            string[] res = comboResMonitor.SelectedItem.ToString().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            SetResMonitorX(client, int.Parse(res[0]));
            SetResMonitorY(client, int.Parse(res[1]));

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton8.Enabled = true;
            radioButton9.Enabled = true;
            radioButton10.Enabled = true;
            radioButton11.Enabled = true;
            radioButton12.Enabled = true;
            radioButton13.Enabled = true;
            radioButton14.Enabled = true;
            radioButton15.Enabled = true;
            radioButton16.Enabled = true;
            radioButton17.Enabled = true;
            radioButton18.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            radioButton23.Enabled = true;
            radioButton24.Enabled = true;
            radioButton25.Enabled = true;
            radioButton26.Enabled = true;
        }

        #region radioButtonsCheckedChanged

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 0);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = false;
            checkBw2.Enabled = false;
            checkBw3.Enabled = false;
            checkBw4.Enabled = false;
            checkBw5.Enabled = false;
            checkBw6.Enabled = false;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 1);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = false;
            checkBw3.Enabled = false;
            checkBw4.Enabled = false;
            checkBw5.Enabled = false;
            checkBw6.Enabled = false;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 2);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = false;
            checkBw4.Enabled = false;
            checkBw5.Enabled = false;
            checkBw6.Enabled = false;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 3);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = false;
            checkBw4.Enabled = false;
            checkBw5.Enabled = false;
            checkBw6.Enabled = false;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 4);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = false;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 5);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = false;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 6);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 7);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = false;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 8);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = false;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 9);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 10);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = false;
            checkBw5.Enabled = false;
            checkBw6.Enabled = false;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 11);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 12);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 13);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 14);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = false;
            checkBw8.Enabled = false;
            checkBw9.Enabled = false;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 15);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = true;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 16);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = true;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 17);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = true;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 18);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = true;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 19);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = true;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 20);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = true;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 21);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = true;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 22);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = true;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 23);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = true;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 24);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = true;
            checkBw10.Enabled = false;
            checkBw11.Enabled = false;
            checkBw12.Enabled = false;
            checkBw13.Enabled = false;
            checkBw14.Enabled = false;
            checkBw15.Enabled = false;

            displayRes();
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            SetShape(client, 25);
            
            checkBw0.Enabled = true;
            checkBw1.Enabled = true;
            checkBw2.Enabled = true;
            checkBw3.Enabled = true;
            checkBw4.Enabled = true;
            checkBw5.Enabled = true;
            checkBw6.Enabled = true;
            checkBw7.Enabled = true;
            checkBw8.Enabled = true;
            checkBw9.Enabled = true;
            checkBw10.Enabled = true;
            checkBw11.Enabled = true;
            checkBw12.Enabled = true;
            checkBw13.Enabled = true;
            checkBw14.Enabled = true;
            checkBw15.Enabled = true;

            displayRes();
        }

        #endregion

        #region useful Methods

        public void displayRes()
        {
            CalculateRes(client);
            if (GetResX(client, 0) != -1 && GetResY(client, 0) != -1)
                textBox2.Text = GetResX(client, 0).ToString() + " x " + GetResY(client, 0);
            else
                textBox2.Text = "";

            if (GetResX(client, 1) != -1 && GetResY(client, 1) != -1)
                textBox3.Text = GetResX(client, 1).ToString() + " x " + GetResY(client, 1);
            else
                textBox3.Text = "";

            if (GetResX(client, 2) != -1 && GetResY(client, 2) != -1)
                textBox4.Text = GetResX(client, 2).ToString() + " x " + GetResY(client, 2);
            else
                textBox4.Text = "";

            if (GetResX(client, 3) != -1 && GetResY(client, 3) != -1)
                textBox5.Text = GetResX(client, 3).ToString() + " x " + GetResY(client, 3);
            else
                textBox5.Text = "";

            if (GetResX(client, 4) != -1 && GetResY(client, 4) != -1)
                textBox6.Text = GetResX(client, 4).ToString() + " x " + GetResY(client, 4);
            else
                textBox6.Text = "";

            if (GetResX(client, 5) != -1 && GetResY(client, 5) != -1)
                textBox7.Text = GetResX(client, 5).ToString() + " x " + GetResY(client, 5);
            else
                textBox7.Text = "";

            if (GetResX(client, 6) != -1 && GetResY(client, 6) != -1)
                textBox8.Text = GetResX(client, 6).ToString() + " x " + GetResY(client, 6);
            else
                textBox8.Text = "";

            if (GetResX(client, 7) != -1 && GetResY(client, 7) != -1)
                textBox9.Text = GetResX(client, 7).ToString() + " x " + GetResY(client, 7);
            else
                textBox9.Text = "";

            if (GetResX(client, 8) != -1 && GetResY(client, 8) != -1)
                textBox10.Text = GetResX(client, 8).ToString() + " x " + GetResY(client, 8);
            else
                textBox10.Text = "";

            if (GetResX(client, 9) != -1 && GetResY(client, 9) != -1)
                textBox11.Text = GetResX(client, 9).ToString() + " x " + GetResY(client, 9);
            else
                textBox11.Text = "";

            if (GetResX(client, 10) != -1 && GetResY(client, 10) != -1)
                textBox12.Text = GetResX(client, 10).ToString() + " x " + GetResY(client, 10);
            else
                textBox12.Text = "";

            if (GetResX(client, 11) != -1 && GetResY(client, 11) != -1)
                textBox13.Text = GetResX(client, 11).ToString() + " x " + GetResY(client, 11);
            else
                textBox13.Text = "";

            if (GetResX(client, 12) != -1 && GetResY(client, 12) != -1)
                textBox14.Text = GetResX(client, 12).ToString() + " x " + GetResY(client, 12);
            else
                textBox14.Text = "";

            if (GetResX(client, 13) != -1 && GetResY(client, 13) != -1)
                textBox15.Text = GetResX(client, 13).ToString() + " x " + GetResY(client, 13);
            else
                textBox15.Text = "";

            if (GetResX(client, 14) != -1 && GetResY(client, 14) != -1)
                textBox16.Text = GetResX(client, 14).ToString() + " x " + GetResY(client, 14);
            else
                textBox16.Text = "";

            if (GetResX(client, 15) != -1 && GetResY(client, 15) != -1)
                textBox17.Text = GetResX(client, 15).ToString() + " x " + GetResY(client, 15);
            else
                textBox17.Text = "";
            buttonSend.Enabled = true;
        }

        public string getRes(int tb)
        {
            switch (tb)
            {
                case 0:
                    return textBox2.Text;
                case 1:
                    return textBox3.Text;
                case 2:
                    return textBox4.Text;
                case 3:
                    return textBox5.Text;
                case 4:
                    return textBox6.Text;
                case 5:
                    return textBox7.Text;
                case 6:
                    return textBox8.Text;
                case 7:
                    return textBox9.Text;
                case 8:
                    return textBox10.Text;
                case 9:
                    return textBox11.Text;
                case 10:
                    return textBox12.Text;
                case 11:
                    return textBox13.Text;
                case 12:
                    return textBox14.Text;
                case 13:
                    return textBox15.Text;
                case 14:
                    return textBox16.Text;
                case 15:
                    return textBox17.Text;
                default:
                    return "";
            }
        }

        public bool getBW(int cb)
        {
            switch (cb)
            {
                case 0:
                    return checkBw0.Checked;
                case 1:
                    return checkBw1.Checked;
                case 2:
                    return checkBw2.Checked;
                case 3:
                    return checkBw3.Checked;
                case 4:
                    return checkBw4.Checked;
                case 5:
                    return checkBw5.Checked;
                case 6:
                    return checkBw6.Checked;
                case 7:
                    return checkBw7.Checked;
                case 8:
                    return checkBw8.Checked;
                case 9:
                    return checkBw9.Checked;
                case 10:
                    return checkBw10.Checked;
                case 11:
                    return checkBw11.Checked;
                case 12:
                    return checkBw12.Checked;
                case 13:
                    return checkBw13.Checked;
                case 14:
                    return checkBw14.Checked;
                case 15:
                    return checkBw15.Checked;
                default:
                    return false;
            }
        }

        #endregion

    }
}
