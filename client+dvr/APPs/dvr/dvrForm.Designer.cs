using System.Runtime.InteropServices;
using System;
namespace dvrAPP
{
    partial class dvrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region testMethods

        [DllImport("dvr.dll")]
        public static extern int myadd(int a, int b);

        [DllImport("dvr.dll")]
        public static extern int printmsg(IntPtr ptr);

        [DllImport("dvr.dll")]
        public static extern IntPtr increasePORT(IntPtr ptr);

        [DllImport("dvr.dll")]
        public static extern int getResX(IntPtr ptr, int cam);

        [DllImport("dvr.dll")]
        public static extern int getResY(IntPtr ptr, int cam);

        [DllImport("dvr.dll")]
        public static extern bool GetBW(IntPtr ptr, char[] cam);

        [DllImport("dvr.dll")]
        public static extern int getPort(IntPtr ptr);

        [DllImport("dvr.dll")]
        public static extern void setPort(IntPtr ptr, int port);

        #endregion

        #region dvrMethods

        [DllImport("dvr.dll")]
        public static extern IntPtr createDVR();

        [DllImport("dvr.dll")]
        public static extern bool Listen(IntPtr ptr, int port);

        [DllImport("dvr.dll")]
        public static extern int RecvResCam(IntPtr ptr, int cam);

        [DllImport("dvr.dll")]
        public static extern bool RecvBWCam(IntPtr ptr);
        
        [DllImport("dvr.dll")]
        public static extern bool CloseConnection(IntPtr ptr);

        [DllImport("dvr.dll")]
        public static extern IntPtr GetImage(IntPtr ptr, char[] filePath);

        [DllImport("dvr.dll")]
        public static extern int GetImageCount(IntPtr ptr);

        [DllImport("dvr.dll")]
        public static extern int DeleteImage(IntPtr ptr, int index);

        [DllImport("dvr.dll")]
        public static extern int DeleteAllImages(IntPtr ptr);

        [DllImport("dvr.dll")]
        public static extern bool Process(IntPtr ptr, IntPtr image, char[] inputPath, char[] outputPath, int height, int width, bool bw);

        #endregion

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.browseInput = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.browseOutput = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.labelMaxim = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.comboMaxim = new System.Windows.Forms.ComboBox();
            this.textCurrent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPercent = new System.Windows.Forms.TextBox();
            this.labelPercent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerRecv = new System.Windows.Forms.Timer(this.components);
            this.buttonBW = new System.Windows.Forms.Button();
            this.timerWarning = new System.Windows.Forms.Timer(this.components);
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelYesBW = new System.Windows.Forms.Label();
            this.labelNoBW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Enabled = false;
            this.textInput.Location = new System.Drawing.Point(99, 15);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(245, 20);
            this.textInput.TabIndex = 1;
            this.textInput.Text = "C:\\Users\\didi\\Desktop\\UTI\\input";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInput.ForeColor = System.Drawing.Color.Red;
            this.labelInput.Location = new System.Drawing.Point(12, 17);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(71, 16);
            this.labelInput.TabIndex = 2;
            this.labelInput.Text = "Input folder:";
            // 
            // browseInput
            // 
            this.browseInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.browseInput.ForeColor = System.Drawing.Color.Red;
            this.browseInput.Location = new System.Drawing.Point(350, 13);
            this.browseInput.Name = "browseInput";
            this.browseInput.Size = new System.Drawing.Size(32, 23);
            this.browseInput.TabIndex = 3;
            this.browseInput.Text = "...";
            this.browseInput.UseVisualStyleBackColor = true;
            this.browseInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOutput.ForeColor = System.Drawing.Color.Green;
            this.labelOutput.Location = new System.Drawing.Point(12, 52);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(80, 16);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Output folder:";
            // 
            // textOutput
            // 
            this.textOutput.Enabled = false;
            this.textOutput.Location = new System.Drawing.Point(99, 50);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(245, 20);
            this.textOutput.TabIndex = 5;
            this.textOutput.Text = "C:\\Users\\didi\\Desktop\\UTI\\output";
            // 
            // browseOutput
            // 
            this.browseOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.browseOutput.ForeColor = System.Drawing.Color.Green;
            this.browseOutput.Location = new System.Drawing.Point(350, 48);
            this.browseOutput.Name = "browseOutput";
            this.browseOutput.Size = new System.Drawing.Size(32, 23);
            this.browseOutput.TabIndex = 6;
            this.browseOutput.Text = "...";
            this.browseOutput.UseVisualStyleBackColor = true;
            this.browseOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // processButton
            // 
            this.processButton.Enabled = false;
            this.processButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.processButton.ForeColor = System.Drawing.Color.Black;
            this.processButton.Location = new System.Drawing.Point(276, 312);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(106, 23);
            this.processButton.TabIndex = 7;
            this.processButton.Text = "Process Images";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // labelMaxim
            // 
            this.labelMaxim.AutoSize = true;
            this.labelMaxim.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMaxim.Location = new System.Drawing.Point(12, 117);
            this.labelMaxim.Name = "labelMaxim";
            this.labelMaxim.Size = new System.Drawing.Size(39, 16);
            this.labelMaxim.TabIndex = 8;
            this.labelMaxim.Text = "Maxim";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrent.Location = new System.Drawing.Point(12, 144);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(48, 16);
            this.labelCurrent.TabIndex = 9;
            this.labelCurrent.Text = "Current";
            // 
            // comboMaxim
            // 
            this.comboMaxim.FormattingEnabled = true;
            this.comboMaxim.Location = new System.Drawing.Point(98, 115);
            this.comboMaxim.Name = "comboMaxim";
            this.comboMaxim.Size = new System.Drawing.Size(84, 21);
            this.comboMaxim.TabIndex = 10;
            // 
            // textCurrent
            // 
            this.textCurrent.Location = new System.Drawing.Point(98, 142);
            this.textCurrent.Name = "textCurrent";
            this.textCurrent.Size = new System.Drawing.Size(84, 20);
            this.textCurrent.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(188, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "K";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(188, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "K";
            // 
            // textPercent
            // 
            this.textPercent.Enabled = false;
            this.textPercent.Location = new System.Drawing.Point(99, 197);
            this.textPercent.Name = "textPercent";
            this.textPercent.Size = new System.Drawing.Size(83, 20);
            this.textPercent.TabIndex = 19;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(12, 200);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(44, 13);
            this.labelPercent.TabIndex = 21;
            this.labelPercent.Text = "Percent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "%";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 217);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Observatii:";
            // 
            // timerRecv
            // 
            this.timerRecv.Enabled = true;
            this.timerRecv.Interval = 1;
            this.timerRecv.Tick += new System.EventHandler(this.timerRecv_Tick);
            // 
            // buttonBW
            // 
            this.buttonBW.Enabled = false;
            this.buttonBW.Location = new System.Drawing.Point(99, 168);
            this.buttonBW.Name = "buttonBW";
            this.buttonBW.Size = new System.Drawing.Size(83, 23);
            this.buttonBW.TabIndex = 25;
            this.buttonBW.Text = "BW ?";
            this.buttonBW.UseVisualStyleBackColor = true;
            this.buttonBW.Click += new System.EventHandler(this.buttonBW_Click);
            // 
            // timerWarning
            // 
            this.timerWarning.Enabled = true;
            this.timerWarning.Tick += new System.EventHandler(this.timerWarning_Tick);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.labelWarning.Location = new System.Drawing.Point(12, 233);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(236, 13);
            this.labelWarning.TabIndex = 26;
            this.labelWarning.Text = "! Current value must be less than maximum value";
            this.labelWarning.Visible = false;
            // 
            // labelYesBW
            // 
            this.labelYesBW.AutoSize = true;
            this.labelYesBW.ForeColor = System.Drawing.Color.DarkRed;
            this.labelYesBW.Location = new System.Drawing.Point(15, 233);
            this.labelYesBW.Name = "labelYesBW";
            this.labelYesBW.Size = new System.Drawing.Size(225, 13);
            this.labelYesBW.TabIndex = 27;
            this.labelYesBW.Text = "A BW filter will be applied to all images. (70%+)";
            this.labelYesBW.Visible = false;
            // 
            // labelNoBW
            // 
            this.labelNoBW.AutoSize = true;
            this.labelNoBW.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNoBW.Location = new System.Drawing.Point(12, 233);
            this.labelNoBW.Name = "labelNoBW";
            this.labelNoBW.Size = new System.Drawing.Size(93, 13);
            this.labelNoBW.TabIndex = 28;
            this.labelNoBW.Text = "No extra BW filter.";
            this.labelNoBW.Visible = false;
            // 
            // dvrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 345);
            this.Controls.Add(this.labelNoBW);
            this.Controls.Add(this.labelYesBW);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonBW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.textPercent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCurrent);
            this.Controls.Add(this.comboMaxim);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.labelMaxim);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.browseOutput);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.browseInput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textInput);
            this.Name = "dvrForm";
            this.Text = "DVR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button browseInput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button browseOutput;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label labelMaxim;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.ComboBox comboMaxim;
        private System.Windows.Forms.TextBox textCurrent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPercent;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerRecv;
        private System.Windows.Forms.Button buttonBW;
        private System.Windows.Forms.Timer timerWarning;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Label labelYesBW;
        private System.Windows.Forms.Label labelNoBW;
    }
}

