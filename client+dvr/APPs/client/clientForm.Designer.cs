using System.Runtime.InteropServices;
using System;

namespace dvrClient
{
    partial class clientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region clientMethods

        [DllImport("client.dll")]
        public static extern IntPtr createClient();

        [DllImport("client.dll")]
        public static extern bool SetShape(IntPtr ptr, int shape);

        [DllImport("client.dll")]
        public static extern bool CalculateRes(IntPtr ptr);

        [DllImport("client.dll")]
        public static extern bool SetResCamX(IntPtr ptr, int cam, int value);

        [DllImport("client.dll")]
        public static extern bool SetResCamY(IntPtr ptr, int cam, int value);

        [DllImport("client.dll")]
        public static extern bool SetResMonitorX(IntPtr ptr, int res);

        [DllImport("client.dll")]
        public static extern bool SetResMonitorY(IntPtr ptr, int res);

        [DllImport("client.dll")]
        public static extern int GetShape(IntPtr ptr);

        [DllImport("client.dll")]
        public static extern int GetResX(IntPtr ptr, int cam);

        [DllImport("client.dll")]
        public static extern int GetResY(IntPtr ptr, int cam);




        [DllImport("client.dll")]
        public static extern bool Connect(IntPtr ptr);

        [DllImport("client.dll")]
        public static extern char SendRes(IntPtr ptr, int resY, int resX, int cam);

        [DllImport("client.dll")]
        public static extern char SendBWCam(IntPtr ptr, int bw, int cam);

        [DllImport("client.dll")]
        public static extern bool CloseConnection(IntPtr ptr);

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
            this.label2 = new System.Windows.Forms.Label();
            this.comboResMonitor = new System.Windows.Forms.ComboBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.label218 = new System.Windows.Forms.Label();
            this.label219 = new System.Windows.Forms.Label();
            this.label220 = new System.Windows.Forms.Label();
            this.label221 = new System.Windows.Forms.Label();
            this.label226 = new System.Windows.Forms.Label();
            this.label227 = new System.Windows.Forms.Label();
            this.label228 = new System.Windows.Forms.Label();
            this.label205 = new System.Windows.Forms.Label();
            this.label208 = new System.Windows.Forms.Label();
            this.label229 = new System.Windows.Forms.Label();
            this.label207 = new System.Windows.Forms.Label();
            this.label214 = new System.Windows.Forms.Label();
            this.label206 = new System.Windows.Forms.Label();
            this.label215 = new System.Windows.Forms.Label();
            this.label216 = new System.Windows.Forms.Label();
            this.label217 = new System.Windows.Forms.Label();
            this.label222 = new System.Windows.Forms.Label();
            this.label223 = new System.Windows.Forms.Label();
            this.label224 = new System.Windows.Forms.Label();
            this.label225 = new System.Windows.Forms.Label();
            this.label201 = new System.Windows.Forms.Label();
            this.label202 = new System.Windows.Forms.Label();
            this.label203 = new System.Windows.Forms.Label();
            this.label204 = new System.Windows.Forms.Label();
            this.label209 = new System.Windows.Forms.Label();
            this.label210 = new System.Windows.Forms.Label();
            this.label211 = new System.Windows.Forms.Label();
            this.label212 = new System.Windows.Forms.Label();
            this.label213 = new System.Windows.Forms.Label();
            this.label196 = new System.Windows.Forms.Label();
            this.label198 = new System.Windows.Forms.Label();
            this.label199 = new System.Windows.Forms.Label();
            this.label200 = new System.Windows.Forms.Label();
            this.label188 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.label190 = new System.Windows.Forms.Label();
            this.label191 = new System.Windows.Forms.Label();
            this.label192 = new System.Windows.Forms.Label();
            this.label193 = new System.Windows.Forms.Label();
            this.label194 = new System.Windows.Forms.Label();
            this.label195 = new System.Windows.Forms.Label();
            this.label197 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.label181 = new System.Windows.Forms.Label();
            this.label182 = new System.Windows.Forms.Label();
            this.label183 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.label185 = new System.Windows.Forms.Label();
            this.label186 = new System.Windows.Forms.Label();
            this.label187 = new System.Windows.Forms.Label();
            this.label175 = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.label177 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.label179 = new System.Windows.Forms.Label();
            this.label170 = new System.Windows.Forms.Label();
            this.label171 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.label169 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBw15 = new System.Windows.Forms.CheckBox();
            this.checkBw2 = new System.Windows.Forms.CheckBox();
            this.checkBw14 = new System.Windows.Forms.CheckBox();
            this.checkBw0 = new System.Windows.Forms.CheckBox();
            this.checkBw13 = new System.Windows.Forms.CheckBox();
            this.checkBw1 = new System.Windows.Forms.CheckBox();
            this.checkBw12 = new System.Windows.Forms.CheckBox();
            this.checkBw3 = new System.Windows.Forms.CheckBox();
            this.checkBw11 = new System.Windows.Forms.CheckBox();
            this.checkBw4 = new System.Windows.Forms.CheckBox();
            this.checkBw10 = new System.Windows.Forms.CheckBox();
            this.checkBw5 = new System.Windows.Forms.CheckBox();
            this.checkBw9 = new System.Windows.Forms.CheckBox();
            this.checkBw6 = new System.Windows.Forms.CheckBox();
            this.checkBw8 = new System.Windows.Forms.CheckBox();
            this.checkBw7 = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monitor Resolution";
            // 
            // comboResMonitor
            // 
            this.comboResMonitor.FormattingEnabled = true;
            this.comboResMonitor.Location = new System.Drawing.Point(121, 9);
            this.comboResMonitor.Name = "comboResMonitor";
            this.comboResMonitor.Size = new System.Drawing.Size(71, 21);
            this.comboResMonitor.TabIndex = 3;
            this.comboResMonitor.SelectedIndexChanged += new System.EventHandler(this.comboRes_SelectedIndexChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(873, 425);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(795, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 137;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox17
            // 
            this.textBox17.Enabled = false;
            this.textBox17.Location = new System.Drawing.Point(126, 320);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(63, 20);
            this.textBox17.TabIndex = 103;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.Enabled = false;
            this.textBox16.Location = new System.Drawing.Point(126, 277);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(63, 20);
            this.textBox16.TabIndex = 102;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.Enabled = false;
            this.textBox15.Location = new System.Drawing.Point(126, 234);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(63, 20);
            this.textBox15.TabIndex = 101;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(126, 191);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(63, 20);
            this.textBox14.TabIndex = 100;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(126, 148);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(63, 20);
            this.textBox13.TabIndex = 99;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(126, 105);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(63, 20);
            this.textBox12.TabIndex = 98;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(126, 62);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(63, 20);
            this.textBox11.TabIndex = 97;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(126, 19);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(63, 20);
            this.textBox10.TabIndex = 96;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(30, 320);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(63, 20);
            this.textBox9.TabIndex = 95;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(30, 277);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(63, 20);
            this.textBox8.TabIndex = 94;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(30, 234);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(63, 20);
            this.textBox7.TabIndex = 93;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(30, 191);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(63, 20);
            this.textBox6.TabIndex = 92;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(30, 148);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(63, 20);
            this.textBox5.TabIndex = 91;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(30, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 20);
            this.textBox4.TabIndex = 90;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(30, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(63, 20);
            this.textBox3.TabIndex = 89;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(107, 323);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 86;
            this.label18.Text = "15";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(107, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 85;
            this.label17.Text = "14";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(107, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 84;
            this.label16.Text = "13";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 83;
            this.label15.Text = "12";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(107, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 82;
            this.label14.Text = "11";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(107, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 81;
            this.label13.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(30, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 20);
            this.textBox2.TabIndex = 88;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.textBox13);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.textBox17);
            this.groupBox1.Location = new System.Drawing.Point(742, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 359);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera Resolutions:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton26);
            this.groupBox2.Controls.Add(this.label218);
            this.groupBox2.Controls.Add(this.label219);
            this.groupBox2.Controls.Add(this.label220);
            this.groupBox2.Controls.Add(this.label221);
            this.groupBox2.Controls.Add(this.label226);
            this.groupBox2.Controls.Add(this.label227);
            this.groupBox2.Controls.Add(this.label228);
            this.groupBox2.Controls.Add(this.label205);
            this.groupBox2.Controls.Add(this.label208);
            this.groupBox2.Controls.Add(this.label229);
            this.groupBox2.Controls.Add(this.label207);
            this.groupBox2.Controls.Add(this.label214);
            this.groupBox2.Controls.Add(this.label206);
            this.groupBox2.Controls.Add(this.label215);
            this.groupBox2.Controls.Add(this.label216);
            this.groupBox2.Controls.Add(this.label217);
            this.groupBox2.Controls.Add(this.label222);
            this.groupBox2.Controls.Add(this.label223);
            this.groupBox2.Controls.Add(this.label224);
            this.groupBox2.Controls.Add(this.label225);
            this.groupBox2.Controls.Add(this.label201);
            this.groupBox2.Controls.Add(this.label202);
            this.groupBox2.Controls.Add(this.label203);
            this.groupBox2.Controls.Add(this.label204);
            this.groupBox2.Controls.Add(this.label209);
            this.groupBox2.Controls.Add(this.label210);
            this.groupBox2.Controls.Add(this.label211);
            this.groupBox2.Controls.Add(this.label212);
            this.groupBox2.Controls.Add(this.label213);
            this.groupBox2.Controls.Add(this.label196);
            this.groupBox2.Controls.Add(this.label198);
            this.groupBox2.Controls.Add(this.label199);
            this.groupBox2.Controls.Add(this.label200);
            this.groupBox2.Controls.Add(this.label188);
            this.groupBox2.Controls.Add(this.label189);
            this.groupBox2.Controls.Add(this.label190);
            this.groupBox2.Controls.Add(this.label191);
            this.groupBox2.Controls.Add(this.label192);
            this.groupBox2.Controls.Add(this.label193);
            this.groupBox2.Controls.Add(this.label194);
            this.groupBox2.Controls.Add(this.label195);
            this.groupBox2.Controls.Add(this.label197);
            this.groupBox2.Controls.Add(this.label180);
            this.groupBox2.Controls.Add(this.label181);
            this.groupBox2.Controls.Add(this.label182);
            this.groupBox2.Controls.Add(this.label183);
            this.groupBox2.Controls.Add(this.label184);
            this.groupBox2.Controls.Add(this.label185);
            this.groupBox2.Controls.Add(this.label186);
            this.groupBox2.Controls.Add(this.label187);
            this.groupBox2.Controls.Add(this.label175);
            this.groupBox2.Controls.Add(this.label176);
            this.groupBox2.Controls.Add(this.label177);
            this.groupBox2.Controls.Add(this.label178);
            this.groupBox2.Controls.Add(this.label179);
            this.groupBox2.Controls.Add(this.label170);
            this.groupBox2.Controls.Add(this.label171);
            this.groupBox2.Controls.Add(this.label172);
            this.groupBox2.Controls.Add(this.label173);
            this.groupBox2.Controls.Add(this.label174);
            this.groupBox2.Controls.Add(this.label162);
            this.groupBox2.Controls.Add(this.label163);
            this.groupBox2.Controls.Add(this.label164);
            this.groupBox2.Controls.Add(this.label165);
            this.groupBox2.Controls.Add(this.label166);
            this.groupBox2.Controls.Add(this.label167);
            this.groupBox2.Controls.Add(this.label168);
            this.groupBox2.Controls.Add(this.label169);
            this.groupBox2.Controls.Add(this.label154);
            this.groupBox2.Controls.Add(this.label155);
            this.groupBox2.Controls.Add(this.label156);
            this.groupBox2.Controls.Add(this.label157);
            this.groupBox2.Controls.Add(this.label158);
            this.groupBox2.Controls.Add(this.label159);
            this.groupBox2.Controls.Add(this.label160);
            this.groupBox2.Controls.Add(this.label161);
            this.groupBox2.Controls.Add(this.label152);
            this.groupBox2.Controls.Add(this.label153);
            this.groupBox2.Controls.Add(this.label144);
            this.groupBox2.Controls.Add(this.label145);
            this.groupBox2.Controls.Add(this.label146);
            this.groupBox2.Controls.Add(this.label147);
            this.groupBox2.Controls.Add(this.label148);
            this.groupBox2.Controls.Add(this.label149);
            this.groupBox2.Controls.Add(this.label150);
            this.groupBox2.Controls.Add(this.label151);
            this.groupBox2.Controls.Add(this.label142);
            this.groupBox2.Controls.Add(this.label143);
            this.groupBox2.Controls.Add(this.label137);
            this.groupBox2.Controls.Add(this.label139);
            this.groupBox2.Controls.Add(this.label140);
            this.groupBox2.Controls.Add(this.label141);
            this.groupBox2.Controls.Add(this.label132);
            this.groupBox2.Controls.Add(this.label133);
            this.groupBox2.Controls.Add(this.label134);
            this.groupBox2.Controls.Add(this.label135);
            this.groupBox2.Controls.Add(this.label136);
            this.groupBox2.Controls.Add(this.label138);
            this.groupBox2.Controls.Add(this.label127);
            this.groupBox2.Controls.Add(this.label128);
            this.groupBox2.Controls.Add(this.label129);
            this.groupBox2.Controls.Add(this.label130);
            this.groupBox2.Controls.Add(this.label131);
            this.groupBox2.Controls.Add(this.label122);
            this.groupBox2.Controls.Add(this.label123);
            this.groupBox2.Controls.Add(this.label124);
            this.groupBox2.Controls.Add(this.label125);
            this.groupBox2.Controls.Add(this.label126);
            this.groupBox2.Controls.Add(this.label118);
            this.groupBox2.Controls.Add(this.label119);
            this.groupBox2.Controls.Add(this.label120);
            this.groupBox2.Controls.Add(this.label121);
            this.groupBox2.Controls.Add(this.label114);
            this.groupBox2.Controls.Add(this.label115);
            this.groupBox2.Controls.Add(this.label116);
            this.groupBox2.Controls.Add(this.label117);
            this.groupBox2.Controls.Add(this.label112);
            this.groupBox2.Controls.Add(this.label113);
            this.groupBox2.Controls.Add(this.label104);
            this.groupBox2.Controls.Add(this.label102);
            this.groupBox2.Controls.Add(this.label105);
            this.groupBox2.Controls.Add(this.label106);
            this.groupBox2.Controls.Add(this.label98);
            this.groupBox2.Controls.Add(this.label107);
            this.groupBox2.Controls.Add(this.label103);
            this.groupBox2.Controls.Add(this.label108);
            this.groupBox2.Controls.Add(this.label97);
            this.groupBox2.Controls.Add(this.label109);
            this.groupBox2.Controls.Add(this.label99);
            this.groupBox2.Controls.Add(this.label110);
            this.groupBox2.Controls.Add(this.label96);
            this.groupBox2.Controls.Add(this.label111);
            this.groupBox2.Controls.Add(this.label100);
            this.groupBox2.Controls.Add(this.label95);
            this.groupBox2.Controls.Add(this.label101);
            this.groupBox2.Controls.Add(this.label91);
            this.groupBox2.Controls.Add(this.label92);
            this.groupBox2.Controls.Add(this.label93);
            this.groupBox2.Controls.Add(this.label94);
            this.groupBox2.Controls.Add(this.label90);
            this.groupBox2.Controls.Add(this.label89);
            this.groupBox2.Controls.Add(this.label88);
            this.groupBox2.Controls.Add(this.label84);
            this.groupBox2.Controls.Add(this.label85);
            this.groupBox2.Controls.Add(this.label86);
            this.groupBox2.Controls.Add(this.label87);
            this.groupBox2.Controls.Add(this.label83);
            this.groupBox2.Controls.Add(this.label82);
            this.groupBox2.Controls.Add(this.label81);
            this.groupBox2.Controls.Add(this.label77);
            this.groupBox2.Controls.Add(this.label78);
            this.groupBox2.Controls.Add(this.label79);
            this.groupBox2.Controls.Add(this.label80);
            this.groupBox2.Controls.Add(this.label74);
            this.groupBox2.Controls.Add(this.label75);
            this.groupBox2.Controls.Add(this.label76);
            this.groupBox2.Controls.Add(this.label73);
            this.groupBox2.Controls.Add(this.label72);
            this.groupBox2.Controls.Add(this.label71);
            this.groupBox2.Controls.Add(this.label70);
            this.groupBox2.Controls.Add(this.label62);
            this.groupBox2.Controls.Add(this.label63);
            this.groupBox2.Controls.Add(this.label64);
            this.groupBox2.Controls.Add(this.label65);
            this.groupBox2.Controls.Add(this.label66);
            this.groupBox2.Controls.Add(this.label67);
            this.groupBox2.Controls.Add(this.label68);
            this.groupBox2.Controls.Add(this.label69);
            this.groupBox2.Controls.Add(this.label61);
            this.groupBox2.Controls.Add(this.label57);
            this.groupBox2.Controls.Add(this.label58);
            this.groupBox2.Controls.Add(this.label59);
            this.groupBox2.Controls.Add(this.label60);
            this.groupBox2.Controls.Add(this.label56);
            this.groupBox2.Controls.Add(this.label55);
            this.groupBox2.Controls.Add(this.label51);
            this.groupBox2.Controls.Add(this.label50);
            this.groupBox2.Controls.Add(this.label52);
            this.groupBox2.Controls.Add(this.label49);
            this.groupBox2.Controls.Add(this.label53);
            this.groupBox2.Controls.Add(this.label44);
            this.groupBox2.Controls.Add(this.label54);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Controls.Add(this.label46);
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.label47);
            this.groupBox2.Controls.Add(this.label42);
            this.groupBox2.Controls.Add(this.label48);
            this.groupBox2.Controls.Add(this.label43);
            this.groupBox2.Controls.Add(this.label45);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.label39);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radioButton25);
            this.groupBox2.Controls.Add(this.radioButton24);
            this.groupBox2.Controls.Add(this.radioButton23);
            this.groupBox2.Controls.Add(this.radioButton22);
            this.groupBox2.Controls.Add(this.radioButton21);
            this.groupBox2.Controls.Add(this.radioButton20);
            this.groupBox2.Controls.Add(this.radioButton19);
            this.groupBox2.Controls.Add(this.radioButton18);
            this.groupBox2.Controls.Add(this.radioButton17);
            this.groupBox2.Controls.Add(this.radioButton16);
            this.groupBox2.Controls.Add(this.radioButton15);
            this.groupBox2.Controls.Add(this.radioButton14);
            this.groupBox2.Controls.Add(this.radioButton13);
            this.groupBox2.Controls.Add(this.radioButton12);
            this.groupBox2.Controls.Add(this.radioButton11);
            this.groupBox2.Controls.Add(this.radioButton10);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 401);
            this.groupBox2.TabIndex = 139;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape:";
            // 
            // radioButton26
            // 
            this.radioButton26.AutoSize = true;
            this.radioButton26.Enabled = false;
            this.radioButton26.Location = new System.Drawing.Point(594, 331);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(14, 13);
            this.radioButton26.TabIndex = 325;
            this.radioButton26.TabStop = true;
            this.radioButton26.UseVisualStyleBackColor = true;
            this.radioButton26.CheckedChanged += new System.EventHandler(this.radioButton26_CheckedChanged);
            // 
            // label218
            // 
            this.label218.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label218.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label218.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label218.Location = new System.Drawing.Point(684, 331);
            this.label218.Name = "label218";
            this.label218.Size = new System.Drawing.Size(21, 13);
            this.label218.TabIndex = 324;
            this.label218.Text = "5";
            this.label218.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label219
            // 
            this.label219.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label219.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label219.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label219.Location = new System.Drawing.Point(684, 345);
            this.label219.Name = "label219";
            this.label219.Size = new System.Drawing.Size(21, 14);
            this.label219.TabIndex = 323;
            this.label219.Text = "7";
            this.label219.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label220
            // 
            this.label220.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label220.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label220.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label220.Location = new System.Drawing.Point(660, 345);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(23, 14);
            this.label220.TabIndex = 322;
            this.label220.Text = "6";
            this.label220.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label221
            // 
            this.label221.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label221.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label221.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label221.Location = new System.Drawing.Point(660, 331);
            this.label221.Name = "label221";
            this.label221.Size = new System.Drawing.Size(23, 13);
            this.label221.TabIndex = 321;
            this.label221.Text = "4";
            this.label221.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label226
            // 
            this.label226.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label226.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label226.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label226.Location = new System.Drawing.Point(637, 331);
            this.label226.Name = "label226";
            this.label226.Size = new System.Drawing.Size(22, 13);
            this.label226.TabIndex = 320;
            this.label226.Text = "1";
            this.label226.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label227
            // 
            this.label227.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label227.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label227.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label227.Location = new System.Drawing.Point(637, 345);
            this.label227.Name = "label227";
            this.label227.Size = new System.Drawing.Size(22, 14);
            this.label227.TabIndex = 319;
            this.label227.Text = "3";
            this.label227.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label228
            // 
            this.label228.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label228.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label228.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label228.Location = new System.Drawing.Point(613, 345);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(23, 14);
            this.label228.TabIndex = 318;
            this.label228.Text = "2";
            this.label228.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label205
            // 
            this.label205.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label205.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label205.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label205.Location = new System.Drawing.Point(520, 331);
            this.label205.Name = "label205";
            this.label205.Size = new System.Drawing.Size(22, 13);
            this.label205.TabIndex = 299;
            this.label205.Text = "1";
            this.label205.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label208
            // 
            this.label208.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label208.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label208.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label208.Location = new System.Drawing.Point(496, 331);
            this.label208.Name = "label208";
            this.label208.Size = new System.Drawing.Size(23, 13);
            this.label208.TabIndex = 296;
            this.label208.Text = "0";
            this.label208.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label229
            // 
            this.label229.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label229.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label229.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label229.Location = new System.Drawing.Point(613, 331);
            this.label229.Name = "label229";
            this.label229.Size = new System.Drawing.Size(23, 13);
            this.label229.TabIndex = 317;
            this.label229.Text = "0";
            this.label229.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label207
            // 
            this.label207.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label207.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label207.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label207.Location = new System.Drawing.Point(496, 345);
            this.label207.Name = "label207";
            this.label207.Size = new System.Drawing.Size(23, 14);
            this.label207.TabIndex = 297;
            this.label207.Text = "2";
            this.label207.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label214
            // 
            this.label214.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label214.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label214.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label214.Location = new System.Drawing.Point(684, 360);
            this.label214.Name = "label214";
            this.label214.Size = new System.Drawing.Size(21, 13);
            this.label214.TabIndex = 316;
            this.label214.Text = "13";
            this.label214.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label206
            // 
            this.label206.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label206.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label206.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label206.Location = new System.Drawing.Point(520, 345);
            this.label206.Name = "label206";
            this.label206.Size = new System.Drawing.Size(22, 14);
            this.label206.TabIndex = 298;
            this.label206.Text = "3";
            this.label206.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label215
            // 
            this.label215.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label215.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label215.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label215.Location = new System.Drawing.Point(684, 374);
            this.label215.Name = "label215";
            this.label215.Size = new System.Drawing.Size(21, 13);
            this.label215.TabIndex = 315;
            this.label215.Text = "15";
            this.label215.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label216
            // 
            this.label216.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label216.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label216.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label216.Location = new System.Drawing.Point(660, 374);
            this.label216.Name = "label216";
            this.label216.Size = new System.Drawing.Size(23, 13);
            this.label216.TabIndex = 314;
            this.label216.Text = "14";
            this.label216.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label217
            // 
            this.label217.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label217.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label217.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label217.Location = new System.Drawing.Point(660, 360);
            this.label217.Name = "label217";
            this.label217.Size = new System.Drawing.Size(23, 13);
            this.label217.TabIndex = 313;
            this.label217.Text = "12";
            this.label217.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label222
            // 
            this.label222.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label222.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label222.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label222.Location = new System.Drawing.Point(637, 360);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(22, 13);
            this.label222.TabIndex = 308;
            this.label222.Text = "9";
            this.label222.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label223
            // 
            this.label223.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label223.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label223.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label223.Location = new System.Drawing.Point(637, 374);
            this.label223.Name = "label223";
            this.label223.Size = new System.Drawing.Size(22, 13);
            this.label223.TabIndex = 307;
            this.label223.Text = "11";
            this.label223.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label224
            // 
            this.label224.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label224.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label224.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label224.Location = new System.Drawing.Point(613, 374);
            this.label224.Name = "label224";
            this.label224.Size = new System.Drawing.Size(23, 13);
            this.label224.TabIndex = 306;
            this.label224.Text = "10";
            this.label224.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label225
            // 
            this.label225.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label225.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label225.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label225.Location = new System.Drawing.Point(613, 360);
            this.label225.Name = "label225";
            this.label225.Size = new System.Drawing.Size(23, 13);
            this.label225.TabIndex = 305;
            this.label225.Text = "8";
            this.label225.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label201
            // 
            this.label201.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label201.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label201.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label201.Location = new System.Drawing.Point(567, 360);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(22, 13);
            this.label201.TabIndex = 303;
            this.label201.Text = "10";
            this.label201.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label202
            // 
            this.label202.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label202.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label202.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label202.Location = new System.Drawing.Point(567, 374);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(22, 13);
            this.label202.TabIndex = 302;
            this.label202.Text = "12";
            this.label202.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label203
            // 
            this.label203.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label203.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label203.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label203.Location = new System.Drawing.Point(543, 374);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(23, 13);
            this.label203.TabIndex = 301;
            this.label203.Text = "11";
            this.label203.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label204
            // 
            this.label204.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label204.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label204.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label204.Location = new System.Drawing.Point(543, 360);
            this.label204.Name = "label204";
            this.label204.Size = new System.Drawing.Size(23, 13);
            this.label204.TabIndex = 300;
            this.label204.Text = "9";
            this.label204.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label209
            // 
            this.label209.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label209.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label209.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label209.Location = new System.Drawing.Point(520, 360);
            this.label209.Name = "label209";
            this.label209.Size = new System.Drawing.Size(22, 13);
            this.label209.TabIndex = 295;
            this.label209.Text = "6";
            this.label209.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label210
            // 
            this.label210.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label210.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label210.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label210.Location = new System.Drawing.Point(520, 374);
            this.label210.Name = "label210";
            this.label210.Size = new System.Drawing.Size(22, 13);
            this.label210.TabIndex = 294;
            this.label210.Text = "8";
            this.label210.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label211
            // 
            this.label211.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label211.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label211.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label211.Location = new System.Drawing.Point(496, 374);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(23, 13);
            this.label211.TabIndex = 293;
            this.label211.Text = "7";
            this.label211.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label212
            // 
            this.label212.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label212.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label212.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label212.Location = new System.Drawing.Point(496, 360);
            this.label212.Name = "label212";
            this.label212.Size = new System.Drawing.Size(23, 13);
            this.label212.TabIndex = 292;
            this.label212.Text = "5";
            this.label212.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label213
            // 
            this.label213.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label213.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label213.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label213.Location = new System.Drawing.Point(543, 331);
            this.label213.Name = "label213";
            this.label213.Size = new System.Drawing.Size(46, 28);
            this.label213.TabIndex = 291;
            this.label213.Text = "4";
            this.label213.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label196
            // 
            this.label196.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label196.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label196.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label196.Location = new System.Drawing.Point(444, 360);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(22, 13);
            this.label196.TabIndex = 290;
            this.label196.Text = "10";
            this.label196.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label198
            // 
            this.label198.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label198.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label198.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label198.Location = new System.Drawing.Point(444, 374);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(22, 13);
            this.label198.TabIndex = 289;
            this.label198.Text = "12";
            this.label198.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label199
            // 
            this.label199.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label199.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label199.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label199.Location = new System.Drawing.Point(420, 374);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(23, 13);
            this.label199.TabIndex = 288;
            this.label199.Text = "11";
            this.label199.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label200
            // 
            this.label200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label200.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label200.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label200.Location = new System.Drawing.Point(420, 360);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(23, 13);
            this.label200.TabIndex = 287;
            this.label200.Text = "9";
            this.label200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label188
            // 
            this.label188.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label188.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label188.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label188.Location = new System.Drawing.Point(444, 331);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(22, 13);
            this.label188.TabIndex = 286;
            this.label188.Text = "2";
            this.label188.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label189
            // 
            this.label189.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label189.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label189.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label189.Location = new System.Drawing.Point(444, 345);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(22, 14);
            this.label189.TabIndex = 285;
            this.label189.Text = "4";
            this.label189.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label190
            // 
            this.label190.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label190.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label190.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label190.Location = new System.Drawing.Point(420, 345);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(23, 14);
            this.label190.TabIndex = 284;
            this.label190.Text = "3";
            this.label190.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label191
            // 
            this.label191.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label191.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label191.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label191.Location = new System.Drawing.Point(420, 331);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(23, 13);
            this.label191.TabIndex = 283;
            this.label191.Text = "1";
            this.label191.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label192
            // 
            this.label192.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label192.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label192.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label192.Location = new System.Drawing.Point(398, 360);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(21, 13);
            this.label192.TabIndex = 282;
            this.label192.Text = "6";
            this.label192.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label193
            // 
            this.label193.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label193.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label193.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label193.Location = new System.Drawing.Point(398, 374);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(21, 13);
            this.label193.TabIndex = 281;
            this.label193.Text = "8";
            this.label193.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label194
            // 
            this.label194.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label194.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label194.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label194.Location = new System.Drawing.Point(374, 374);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(23, 13);
            this.label194.TabIndex = 280;
            this.label194.Text = "7";
            this.label194.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label195
            // 
            this.label195.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label195.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label195.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label195.Location = new System.Drawing.Point(374, 360);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(23, 13);
            this.label195.TabIndex = 279;
            this.label195.Text = "5";
            this.label195.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label197
            // 
            this.label197.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label197.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label197.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label197.Location = new System.Drawing.Point(374, 331);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(45, 28);
            this.label197.TabIndex = 277;
            this.label197.Text = "0";
            this.label197.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label180
            // 
            this.label180.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label180.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label180.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label180.Location = new System.Drawing.Point(331, 331);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(21, 13);
            this.label180.TabIndex = 276;
            this.label180.Text = "5";
            this.label180.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label181
            // 
            this.label181.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label181.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label181.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label181.Location = new System.Drawing.Point(331, 345);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(21, 14);
            this.label181.TabIndex = 275;
            this.label181.Text = "7";
            this.label181.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label182
            // 
            this.label182.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label182.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label182.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label182.Location = new System.Drawing.Point(307, 345);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(23, 14);
            this.label182.TabIndex = 274;
            this.label182.Text = "6";
            this.label182.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label183
            // 
            this.label183.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label183.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label183.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label183.Location = new System.Drawing.Point(307, 331);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(23, 13);
            this.label183.TabIndex = 273;
            this.label183.Text = "4";
            this.label183.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label184
            // 
            this.label184.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label184.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label184.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label184.Location = new System.Drawing.Point(331, 360);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(21, 13);
            this.label184.TabIndex = 272;
            this.label184.Text = "10";
            this.label184.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label185
            // 
            this.label185.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label185.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label185.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label185.Location = new System.Drawing.Point(331, 374);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(21, 13);
            this.label185.TabIndex = 271;
            this.label185.Text = "12";
            this.label185.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label186
            // 
            this.label186.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label186.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label186.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label186.Location = new System.Drawing.Point(307, 374);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(23, 13);
            this.label186.TabIndex = 270;
            this.label186.Text = "11";
            this.label186.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label187
            // 
            this.label187.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label187.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label187.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label187.Location = new System.Drawing.Point(307, 360);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(23, 13);
            this.label187.TabIndex = 269;
            this.label187.Text = "9";
            this.label187.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label175
            // 
            this.label175.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label175.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label175.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label175.Location = new System.Drawing.Point(284, 331);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(22, 13);
            this.label175.TabIndex = 268;
            this.label175.Text = "1";
            this.label175.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label176
            // 
            this.label176.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label176.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label176.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label176.Location = new System.Drawing.Point(260, 360);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(46, 27);
            this.label176.TabIndex = 264;
            this.label176.Text = "8";
            this.label176.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label177
            // 
            this.label177.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label177.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label177.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label177.Location = new System.Drawing.Point(284, 345);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(22, 14);
            this.label177.TabIndex = 267;
            this.label177.Text = "3";
            this.label177.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label178
            // 
            this.label178.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label178.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label178.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label178.Location = new System.Drawing.Point(260, 345);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(23, 14);
            this.label178.TabIndex = 266;
            this.label178.Text = "2";
            this.label178.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label179
            // 
            this.label179.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label179.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label179.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label179.Location = new System.Drawing.Point(260, 331);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(23, 13);
            this.label179.TabIndex = 265;
            this.label179.Text = "0";
            this.label179.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label170
            // 
            this.label170.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label170.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label170.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label170.Location = new System.Drawing.Point(212, 331);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(22, 13);
            this.label170.TabIndex = 263;
            this.label170.Text = "5";
            this.label170.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label171
            // 
            this.label171.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label171.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label171.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label171.Location = new System.Drawing.Point(188, 360);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(46, 27);
            this.label171.TabIndex = 259;
            this.label171.Text = "12";
            this.label171.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label172
            // 
            this.label172.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label172.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label172.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label172.Location = new System.Drawing.Point(212, 345);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(22, 14);
            this.label172.TabIndex = 262;
            this.label172.Text = "7";
            this.label172.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label173
            // 
            this.label173.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label173.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label173.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label173.Location = new System.Drawing.Point(188, 345);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(23, 14);
            this.label173.TabIndex = 261;
            this.label173.Text = "6";
            this.label173.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label174
            // 
            this.label174.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label174.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label174.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label174.Location = new System.Drawing.Point(188, 331);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(23, 13);
            this.label174.TabIndex = 260;
            this.label174.Text = "4";
            this.label174.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label162
            // 
            this.label162.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label162.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label162.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label162.Location = new System.Drawing.Point(166, 331);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(21, 13);
            this.label162.TabIndex = 258;
            this.label162.Text = "1";
            this.label162.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label163
            // 
            this.label163.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label163.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label163.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label163.Location = new System.Drawing.Point(166, 345);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(21, 14);
            this.label163.TabIndex = 257;
            this.label163.Text = "3";
            this.label163.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label164
            // 
            this.label164.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label164.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label164.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label164.Location = new System.Drawing.Point(142, 345);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(23, 14);
            this.label164.TabIndex = 256;
            this.label164.Text = "2";
            this.label164.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label165
            // 
            this.label165.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label165.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label165.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label165.Location = new System.Drawing.Point(142, 331);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(23, 13);
            this.label165.TabIndex = 255;
            this.label165.Text = "0";
            this.label165.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label166
            // 
            this.label166.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label166.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label166.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label166.Location = new System.Drawing.Point(166, 360);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(21, 13);
            this.label166.TabIndex = 254;
            this.label166.Text = "9";
            this.label166.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label167
            // 
            this.label167.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label167.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label167.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label167.Location = new System.Drawing.Point(166, 374);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(21, 13);
            this.label167.TabIndex = 253;
            this.label167.Text = "11";
            this.label167.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label168
            // 
            this.label168.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label168.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label168.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label168.Location = new System.Drawing.Point(142, 374);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(23, 13);
            this.label168.TabIndex = 252;
            this.label168.Text = "10";
            this.label168.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label169
            // 
            this.label169.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label169.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label169.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label169.Location = new System.Drawing.Point(142, 360);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(23, 13);
            this.label169.TabIndex = 251;
            this.label169.Text = "8";
            this.label169.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label154
            // 
            this.label154.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label154.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label154.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label154.Location = new System.Drawing.Point(683, 270);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(21, 13);
            this.label154.TabIndex = 247;
            this.label154.Text = "7";
            this.label154.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label155
            // 
            this.label155.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label155.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label155.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label155.Location = new System.Drawing.Point(637, 270);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(21, 13);
            this.label155.TabIndex = 250;
            this.label155.Text = "3";
            this.label155.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label156
            // 
            this.label156.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label156.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label156.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label156.Location = new System.Drawing.Point(683, 284);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(21, 13);
            this.label156.TabIndex = 245;
            this.label156.Text = "9";
            this.label156.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label157
            // 
            this.label157.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label157.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label157.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label157.Location = new System.Drawing.Point(637, 284);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(21, 13);
            this.label157.TabIndex = 249;
            this.label157.Text = "5";
            this.label157.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label158
            // 
            this.label158.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label158.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label158.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label158.Location = new System.Drawing.Point(659, 284);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(23, 13);
            this.label158.TabIndex = 244;
            this.label158.Text = "8";
            this.label158.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label159
            // 
            this.label159.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label159.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label159.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label159.Location = new System.Drawing.Point(613, 284);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(23, 13);
            this.label159.TabIndex = 248;
            this.label159.Text = "4";
            this.label159.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label160
            // 
            this.label160.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label160.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label160.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label160.Location = new System.Drawing.Point(659, 270);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(23, 13);
            this.label160.TabIndex = 243;
            this.label160.Text = "6";
            this.label160.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label161
            // 
            this.label161.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label161.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label161.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label161.Location = new System.Drawing.Point(613, 270);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(23, 13);
            this.label161.TabIndex = 246;
            this.label161.Text = "2";
            this.label161.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label152
            // 
            this.label152.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label152.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label152.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label152.Location = new System.Drawing.Point(659, 241);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(45, 28);
            this.label152.TabIndex = 242;
            this.label152.Text = "1";
            this.label152.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label153
            // 
            this.label153.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label153.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label153.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label153.Location = new System.Drawing.Point(613, 241);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(45, 28);
            this.label153.TabIndex = 241;
            this.label153.Text = "0";
            this.label153.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label144
            // 
            this.label144.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label144.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label144.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label144.Location = new System.Drawing.Point(566, 241);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(21, 13);
            this.label144.TabIndex = 240;
            this.label144.Text = "2";
            this.label144.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label145
            // 
            this.label145.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label145.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label145.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label145.Location = new System.Drawing.Point(566, 255);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(21, 14);
            this.label145.TabIndex = 239;
            this.label145.Text = "4";
            this.label145.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label146
            // 
            this.label146.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label146.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label146.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label146.Location = new System.Drawing.Point(542, 255);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(23, 14);
            this.label146.TabIndex = 238;
            this.label146.Text = "3";
            this.label146.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label147
            // 
            this.label147.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label147.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label147.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label147.Location = new System.Drawing.Point(542, 241);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(23, 13);
            this.label147.TabIndex = 237;
            this.label147.Text = "1";
            this.label147.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label148
            // 
            this.label148.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label148.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label148.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label148.Location = new System.Drawing.Point(566, 270);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(21, 13);
            this.label148.TabIndex = 236;
            this.label148.Text = "7";
            this.label148.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label149
            // 
            this.label149.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label149.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label149.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label149.Location = new System.Drawing.Point(566, 284);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(21, 13);
            this.label149.TabIndex = 235;
            this.label149.Text = "9";
            this.label149.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label150
            // 
            this.label150.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label150.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label150.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label150.Location = new System.Drawing.Point(542, 284);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(23, 13);
            this.label150.TabIndex = 234;
            this.label150.Text = "8";
            this.label150.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label151
            // 
            this.label151.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label151.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label151.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label151.Location = new System.Drawing.Point(542, 270);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(23, 13);
            this.label151.TabIndex = 233;
            this.label151.Text = "6";
            this.label151.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label142
            // 
            this.label142.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label142.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label142.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label142.Location = new System.Drawing.Point(496, 270);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(45, 27);
            this.label142.TabIndex = 232;
            this.label142.Text = "5";
            this.label142.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label143
            // 
            this.label143.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label143.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label143.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label143.Location = new System.Drawing.Point(496, 241);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(45, 28);
            this.label143.TabIndex = 231;
            this.label143.Text = "0";
            this.label143.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label137
            // 
            this.label137.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label137.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label137.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label137.Location = new System.Drawing.Point(444, 241);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(21, 13);
            this.label137.TabIndex = 230;
            this.label137.Text = "2";
            this.label137.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label139
            // 
            this.label139.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label139.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label139.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label139.Location = new System.Drawing.Point(444, 255);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(21, 14);
            this.label139.TabIndex = 229;
            this.label139.Text = "4";
            this.label139.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label140
            // 
            this.label140.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label140.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label140.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label140.Location = new System.Drawing.Point(420, 255);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(23, 14);
            this.label140.TabIndex = 228;
            this.label140.Text = "3";
            this.label140.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label141
            // 
            this.label141.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label141.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label141.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label141.Location = new System.Drawing.Point(420, 241);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(23, 13);
            this.label141.TabIndex = 227;
            this.label141.Text = "1";
            this.label141.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label132
            // 
            this.label132.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label132.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label132.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label132.Location = new System.Drawing.Point(398, 270);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(21, 13);
            this.label132.TabIndex = 226;
            this.label132.Text = "6";
            this.label132.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label133
            // 
            this.label133.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label133.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label133.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label133.Location = new System.Drawing.Point(398, 284);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(21, 13);
            this.label133.TabIndex = 225;
            this.label133.Text = "8";
            this.label133.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label134
            // 
            this.label134.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label134.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label134.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label134.Location = new System.Drawing.Point(374, 284);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(23, 13);
            this.label134.TabIndex = 224;
            this.label134.Text = "7";
            this.label134.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label135
            // 
            this.label135.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label135.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label135.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label135.Location = new System.Drawing.Point(374, 270);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(23, 13);
            this.label135.TabIndex = 223;
            this.label135.Text = "5";
            this.label135.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label136
            // 
            this.label136.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label136.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label136.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label136.Location = new System.Drawing.Point(420, 270);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(45, 27);
            this.label136.TabIndex = 222;
            this.label136.Text = "9";
            this.label136.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label138
            // 
            this.label138.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label138.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label138.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label138.Location = new System.Drawing.Point(374, 241);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(45, 28);
            this.label138.TabIndex = 220;
            this.label138.Text = "0";
            this.label138.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label127
            // 
            this.label127.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label127.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label127.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label127.Location = new System.Drawing.Point(284, 241);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(21, 13);
            this.label127.TabIndex = 219;
            this.label127.Text = "1";
            this.label127.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label128
            // 
            this.label128.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label128.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label128.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label128.Location = new System.Drawing.Point(284, 255);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(21, 14);
            this.label128.TabIndex = 218;
            this.label128.Text = "3";
            this.label128.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label129
            // 
            this.label129.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label129.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label129.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label129.Location = new System.Drawing.Point(260, 255);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(23, 14);
            this.label129.TabIndex = 217;
            this.label129.Text = "2";
            this.label129.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label130
            // 
            this.label130.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label130.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label130.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label130.Location = new System.Drawing.Point(260, 241);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(23, 13);
            this.label130.TabIndex = 216;
            this.label130.Text = "0";
            this.label130.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label131
            // 
            this.label131.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label131.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label131.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label131.Location = new System.Drawing.Point(260, 270);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(45, 27);
            this.label131.TabIndex = 215;
            this.label131.Text = "5";
            this.label131.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label122
            // 
            this.label122.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label122.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label122.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label122.Location = new System.Drawing.Point(329, 270);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(22, 13);
            this.label122.TabIndex = 213;
            this.label122.Text = "7";
            this.label122.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label123
            // 
            this.label123.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label123.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label123.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label123.Location = new System.Drawing.Point(306, 241);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(45, 28);
            this.label123.TabIndex = 214;
            this.label123.Text = "4";
            this.label123.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label124
            // 
            this.label124.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label124.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label124.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label124.Location = new System.Drawing.Point(329, 284);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(22, 13);
            this.label124.TabIndex = 212;
            this.label124.Text = "9";
            this.label124.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label125
            // 
            this.label125.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label125.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label125.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label125.Location = new System.Drawing.Point(306, 284);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(22, 13);
            this.label125.TabIndex = 211;
            this.label125.Text = "8";
            this.label125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label126
            // 
            this.label126.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label126.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label126.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label126.Location = new System.Drawing.Point(306, 270);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(22, 13);
            this.label126.TabIndex = 210;
            this.label126.Text = "6";
            this.label126.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label118
            // 
            this.label118.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label118.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label118.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label118.Location = new System.Drawing.Point(166, 241);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(21, 13);
            this.label118.TabIndex = 209;
            this.label118.Text = "1";
            this.label118.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label119
            // 
            this.label119.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label119.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label119.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label119.Location = new System.Drawing.Point(166, 255);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(21, 14);
            this.label119.TabIndex = 208;
            this.label119.Text = "3";
            this.label119.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label120
            // 
            this.label120.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label120.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label120.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label120.Location = new System.Drawing.Point(142, 255);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(23, 14);
            this.label120.TabIndex = 207;
            this.label120.Text = "2";
            this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label121
            // 
            this.label121.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label121.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label121.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label121.Location = new System.Drawing.Point(142, 241);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(23, 13);
            this.label121.TabIndex = 206;
            this.label121.Text = "0";
            this.label121.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label114
            // 
            this.label114.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label114.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label114.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label114.Location = new System.Drawing.Point(166, 270);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(21, 13);
            this.label114.TabIndex = 205;
            this.label114.Text = "6";
            this.label114.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label115
            // 
            this.label115.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label115.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label115.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label115.Location = new System.Drawing.Point(166, 284);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(21, 13);
            this.label115.TabIndex = 204;
            this.label115.Text = "8";
            this.label115.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label116
            // 
            this.label116.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label116.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label116.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label116.Location = new System.Drawing.Point(142, 284);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(23, 13);
            this.label116.TabIndex = 203;
            this.label116.Text = "7";
            this.label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label117
            // 
            this.label117.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label117.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label117.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label117.Location = new System.Drawing.Point(142, 270);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(23, 13);
            this.label117.TabIndex = 202;
            this.label117.Text = "5";
            this.label117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label112
            // 
            this.label112.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label112.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label112.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label112.Location = new System.Drawing.Point(188, 270);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(45, 27);
            this.label112.TabIndex = 201;
            this.label112.Text = "9";
            this.label112.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label113
            // 
            this.label113.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label113.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label113.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label113.Location = new System.Drawing.Point(188, 241);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(45, 28);
            this.label113.TabIndex = 200;
            this.label113.Text = "4";
            this.label113.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label104
            // 
            this.label104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label104.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label104.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label104.Location = new System.Drawing.Point(684, 160);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(22, 13);
            this.label104.TabIndex = 175;
            this.label104.Text = "5";
            this.label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label102
            // 
            this.label102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label102.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label102.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label102.Location = new System.Drawing.Point(660, 189);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(46, 27);
            this.label102.TabIndex = 143;
            this.label102.Text = "9";
            this.label102.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label105
            // 
            this.label105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label105.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label105.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label105.Location = new System.Drawing.Point(638, 160);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(21, 13);
            this.label105.TabIndex = 178;
            this.label105.Text = "1";
            this.label105.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label106
            // 
            this.label106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label106.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label106.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label106.Location = new System.Drawing.Point(684, 174);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(22, 14);
            this.label106.TabIndex = 173;
            this.label106.Text = "7";
            this.label106.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label98
            // 
            this.label98.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label98.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label98.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label98.Location = new System.Drawing.Point(566, 189);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(21, 13);
            this.label98.TabIndex = 150;
            this.label98.Text = "4";
            this.label98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label107
            // 
            this.label107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label107.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label107.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label107.Location = new System.Drawing.Point(638, 174);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(21, 14);
            this.label107.TabIndex = 177;
            this.label107.Text = "3";
            this.label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label103
            // 
            this.label103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label103.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label103.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label103.Location = new System.Drawing.Point(614, 189);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(45, 27);
            this.label103.TabIndex = 142;
            this.label103.Text = "8";
            this.label103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label108
            // 
            this.label108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label108.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label108.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label108.Location = new System.Drawing.Point(660, 174);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(23, 14);
            this.label108.TabIndex = 172;
            this.label108.Text = "6";
            this.label108.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label97
            // 
            this.label97.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label97.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label97.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label97.Location = new System.Drawing.Point(542, 160);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(45, 28);
            this.label97.TabIndex = 199;
            this.label97.Text = "1";
            this.label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label109
            // 
            this.label109.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label109.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label109.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label109.Location = new System.Drawing.Point(614, 174);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(23, 14);
            this.label109.TabIndex = 176;
            this.label109.Text = "2";
            this.label109.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label99
            // 
            this.label99.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label99.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label99.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label99.Location = new System.Drawing.Point(566, 203);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(21, 13);
            this.label99.TabIndex = 149;
            this.label99.Text = "6";
            this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label110
            // 
            this.label110.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label110.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label110.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label110.Location = new System.Drawing.Point(660, 160);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(23, 13);
            this.label110.TabIndex = 171;
            this.label110.Text = "4";
            this.label110.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label96
            // 
            this.label96.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label96.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label96.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label96.Location = new System.Drawing.Point(496, 189);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(45, 27);
            this.label96.TabIndex = 198;
            this.label96.Text = "2";
            this.label96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label111
            // 
            this.label111.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label111.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label111.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label111.Location = new System.Drawing.Point(614, 160);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(23, 13);
            this.label111.TabIndex = 174;
            this.label111.Text = "0";
            this.label111.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label100
            // 
            this.label100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label100.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label100.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label100.Location = new System.Drawing.Point(542, 203);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(23, 13);
            this.label100.TabIndex = 148;
            this.label100.Text = "5";
            this.label100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label95
            // 
            this.label95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label95.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label95.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label95.Location = new System.Drawing.Point(496, 160);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(45, 28);
            this.label95.TabIndex = 197;
            this.label95.Text = "0";
            this.label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label101
            // 
            this.label101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label101.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label101.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label101.Location = new System.Drawing.Point(542, 189);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(23, 13);
            this.label101.TabIndex = 147;
            this.label101.Text = "3";
            this.label101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label91
            // 
            this.label91.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label91.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label91.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label91.Location = new System.Drawing.Point(399, 189);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(22, 13);
            this.label91.TabIndex = 196;
            this.label91.Text = "3";
            this.label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label92
            // 
            this.label92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label92.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label92.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label92.Location = new System.Drawing.Point(399, 203);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(22, 13);
            this.label92.TabIndex = 195;
            this.label92.Text = "5";
            this.label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label93
            // 
            this.label93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label93.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label93.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label93.Location = new System.Drawing.Point(375, 203);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(23, 13);
            this.label93.TabIndex = 194;
            this.label93.Text = "4";
            this.label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label94
            // 
            this.label94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label94.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label94.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label94.Location = new System.Drawing.Point(375, 189);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(23, 13);
            this.label94.TabIndex = 193;
            this.label94.Text = "2";
            this.label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label90
            // 
            this.label90.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label90.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label90.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label90.Location = new System.Drawing.Point(422, 189);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(45, 27);
            this.label90.TabIndex = 192;
            this.label90.Text = "6";
            this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label89
            // 
            this.label89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label89.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label89.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label89.Location = new System.Drawing.Point(422, 160);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(45, 28);
            this.label89.TabIndex = 191;
            this.label89.Text = "1";
            this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label88
            // 
            this.label88.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label88.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label88.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label88.Location = new System.Drawing.Point(375, 160);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(46, 28);
            this.label88.TabIndex = 190;
            this.label88.Text = "0";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label84
            // 
            this.label84.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label84.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label84.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label84.Location = new System.Drawing.Point(331, 160);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(22, 13);
            this.label84.TabIndex = 189;
            this.label84.Text = "2";
            this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label85
            // 
            this.label85.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label85.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label85.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label85.Location = new System.Drawing.Point(331, 174);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(22, 14);
            this.label85.TabIndex = 188;
            this.label85.Text = "4";
            this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label86
            // 
            this.label86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label86.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label86.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label86.Location = new System.Drawing.Point(307, 174);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(23, 14);
            this.label86.TabIndex = 187;
            this.label86.Text = "3";
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label87.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label87.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label87.Location = new System.Drawing.Point(307, 160);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(23, 13);
            this.label87.TabIndex = 186;
            this.label87.Text = "1";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label83
            // 
            this.label83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label83.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label83.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label83.Location = new System.Drawing.Point(307, 189);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(46, 27);
            this.label83.TabIndex = 185;
            this.label83.Text = "6";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label82
            // 
            this.label82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label82.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label82.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label82.Location = new System.Drawing.Point(260, 189);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(46, 27);
            this.label82.TabIndex = 184;
            this.label82.Text = "5";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label81
            // 
            this.label81.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label81.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label81.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label81.Location = new System.Drawing.Point(260, 160);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(46, 28);
            this.label81.TabIndex = 183;
            this.label81.Text = "0";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label77
            // 
            this.label77.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label77.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label77.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label77.Location = new System.Drawing.Point(166, 160);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(22, 13);
            this.label77.TabIndex = 182;
            this.label77.Text = "1";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            this.label78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label78.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label78.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label78.Location = new System.Drawing.Point(166, 174);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(22, 14);
            this.label78.TabIndex = 181;
            this.label78.Text = "3";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label79
            // 
            this.label79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label79.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label79.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label79.Location = new System.Drawing.Point(142, 174);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(23, 14);
            this.label79.TabIndex = 180;
            this.label79.Text = "2";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label80
            // 
            this.label80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label80.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label80.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label80.Location = new System.Drawing.Point(142, 160);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(23, 13);
            this.label80.TabIndex = 179;
            this.label80.Text = "0";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label74
            // 
            this.label74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label74.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label74.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label74.Location = new System.Drawing.Point(189, 189);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(45, 27);
            this.label74.TabIndex = 178;
            this.label74.Text = "6";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label75
            // 
            this.label75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label75.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label75.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label75.Location = new System.Drawing.Point(142, 189);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(46, 27);
            this.label75.TabIndex = 177;
            this.label75.Text = "5";
            this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label76
            // 
            this.label76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label76.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label76.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label76.Location = new System.Drawing.Point(189, 160);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(45, 28);
            this.label76.TabIndex = 176;
            this.label76.Text = "4";
            this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label73
            // 
            this.label73.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label73.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label73.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label73.Location = new System.Drawing.Point(661, 119);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(45, 27);
            this.label73.TabIndex = 174;
            this.label73.Text = "3";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label72
            // 
            this.label72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label72.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label72.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label72.Location = new System.Drawing.Point(614, 119);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(46, 27);
            this.label72.TabIndex = 173;
            this.label72.Text = "2";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label71
            // 
            this.label71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label71.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label71.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label71.Location = new System.Drawing.Point(661, 90);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(45, 28);
            this.label71.TabIndex = 172;
            this.label71.Text = "1";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label70.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label70.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label70.Location = new System.Drawing.Point(614, 90);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(46, 28);
            this.label70.TabIndex = 171;
            this.label70.Text = "0";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label62.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label62.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label62.Location = new System.Drawing.Point(566, 90);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(22, 13);
            this.label62.TabIndex = 167;
            this.label62.Text = "5";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label63.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label63.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label63.Location = new System.Drawing.Point(520, 90);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(21, 13);
            this.label63.TabIndex = 170;
            this.label63.Text = "1";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label64.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label64.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label64.Location = new System.Drawing.Point(566, 104);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(22, 14);
            this.label64.TabIndex = 165;
            this.label64.Text = "7";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label65
            // 
            this.label65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label65.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label65.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label65.Location = new System.Drawing.Point(520, 104);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(21, 14);
            this.label65.TabIndex = 169;
            this.label65.Text = "3";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label66
            // 
            this.label66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label66.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label66.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label66.Location = new System.Drawing.Point(542, 104);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(23, 14);
            this.label66.TabIndex = 164;
            this.label66.Text = "6";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label67
            // 
            this.label67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label67.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label67.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label67.Location = new System.Drawing.Point(496, 104);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(23, 14);
            this.label67.TabIndex = 168;
            this.label67.Text = "2";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label68.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label68.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label68.Location = new System.Drawing.Point(542, 90);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(23, 13);
            this.label68.TabIndex = 163;
            this.label68.Text = "4";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            this.label69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label69.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label69.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label69.Location = new System.Drawing.Point(496, 90);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(23, 13);
            this.label69.TabIndex = 166;
            this.label69.Text = "0";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label61
            // 
            this.label61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label61.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label61.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label61.Location = new System.Drawing.Point(496, 119);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(92, 27);
            this.label61.TabIndex = 162;
            this.label61.Text = "8";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label57
            // 
            this.label57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label57.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label57.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label57.Location = new System.Drawing.Point(445, 90);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(22, 13);
            this.label57.TabIndex = 161;
            this.label57.Text = "2";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label58.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label58.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label58.Location = new System.Drawing.Point(445, 104);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(22, 14);
            this.label58.TabIndex = 160;
            this.label58.Text = "4";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label59
            // 
            this.label59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label59.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label59.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label59.Location = new System.Drawing.Point(421, 104);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(23, 14);
            this.label59.TabIndex = 159;
            this.label59.Text = "3";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label60.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label60.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label60.Location = new System.Drawing.Point(421, 90);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(23, 13);
            this.label60.TabIndex = 158;
            this.label60.Text = "1";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label56.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label56.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label56.Location = new System.Drawing.Point(375, 90);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(45, 28);
            this.label56.TabIndex = 157;
            this.label56.Text = "0";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label55.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label55.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label55.Location = new System.Drawing.Point(375, 119);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(92, 27);
            this.label55.TabIndex = 156;
            this.label55.Text = "5";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label51.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label51.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label51.Location = new System.Drawing.Point(284, 90);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(22, 13);
            this.label51.TabIndex = 145;
            this.label51.Text = "1";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label50.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label50.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label50.Location = new System.Drawing.Point(307, 90);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(45, 28);
            this.label50.TabIndex = 155;
            this.label50.Text = "4";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label52.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label52.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label52.Location = new System.Drawing.Point(284, 104);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(22, 14);
            this.label52.TabIndex = 144;
            this.label52.Text = "3";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label49.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label49.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label49.Location = new System.Drawing.Point(260, 119);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(92, 27);
            this.label49.TabIndex = 154;
            this.label49.Text = "5";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label53.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label53.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label53.Location = new System.Drawing.Point(260, 104);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(23, 14);
            this.label53.TabIndex = 143;
            this.label53.Text = "2";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label44.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label44.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label44.Location = new System.Drawing.Point(212, 119);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(22, 13);
            this.label44.TabIndex = 150;
            this.label44.Text = "6";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label54.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label54.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label54.Location = new System.Drawing.Point(260, 90);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(23, 13);
            this.label54.TabIndex = 142;
            this.label54.Text = "0";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label40.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label40.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label40.Location = new System.Drawing.Point(166, 119);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(21, 13);
            this.label40.TabIndex = 153;
            this.label40.Text = "2";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label46.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label46.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label46.Location = new System.Drawing.Point(212, 133);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(22, 13);
            this.label46.TabIndex = 149;
            this.label46.Text = "8";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label41.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label41.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label41.Location = new System.Drawing.Point(166, 133);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(21, 13);
            this.label41.TabIndex = 152;
            this.label41.Text = "4";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label47.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label47.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label47.Location = new System.Drawing.Point(188, 133);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(23, 13);
            this.label47.TabIndex = 148;
            this.label47.Text = "7";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label42.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label42.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label42.Location = new System.Drawing.Point(142, 133);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(23, 13);
            this.label42.TabIndex = 151;
            this.label42.Text = "3";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label48.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label48.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label48.Location = new System.Drawing.Point(188, 119);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(23, 13);
            this.label48.TabIndex = 147;
            this.label48.Text = "5";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label43.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label43.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label43.Location = new System.Drawing.Point(142, 119);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(23, 13);
            this.label43.TabIndex = 150;
            this.label43.Text = "1";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label45.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label45.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label45.Location = new System.Drawing.Point(142, 90);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(92, 28);
            this.label45.TabIndex = 148;
            this.label45.Text = "0";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBw15);
            this.groupBox4.Controls.Add(this.checkBw2);
            this.groupBox4.Controls.Add(this.checkBw14);
            this.groupBox4.Controls.Add(this.checkBw0);
            this.groupBox4.Controls.Add(this.checkBw13);
            this.groupBox4.Controls.Add(this.checkBw1);
            this.groupBox4.Controls.Add(this.checkBw12);
            this.groupBox4.Controls.Add(this.checkBw3);
            this.groupBox4.Controls.Add(this.checkBw11);
            this.groupBox4.Controls.Add(this.checkBw4);
            this.groupBox4.Controls.Add(this.checkBw10);
            this.groupBox4.Controls.Add(this.checkBw5);
            this.groupBox4.Controls.Add(this.checkBw9);
            this.groupBox4.Controls.Add(this.checkBw6);
            this.groupBox4.Controls.Add(this.checkBw8);
            this.groupBox4.Controls.Add(this.checkBw7);
            this.groupBox4.Location = new System.Drawing.Point(8, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(108, 299);
            this.groupBox4.TabIndex = 147;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BW";
            // 
            // checkBw15
            // 
            this.checkBw15.AutoSize = true;
            this.checkBw15.Location = new System.Drawing.Point(53, 234);
            this.checkBw15.Name = "checkBw15";
            this.checkBw15.Size = new System.Drawing.Size(38, 17);
            this.checkBw15.TabIndex = 155;
            this.checkBw15.Text = "15";
            this.checkBw15.UseVisualStyleBackColor = true;
            // 
            // checkBw2
            // 
            this.checkBw2.AutoSize = true;
            this.checkBw2.Location = new System.Drawing.Point(6, 99);
            this.checkBw2.Name = "checkBw2";
            this.checkBw2.Size = new System.Drawing.Size(32, 17);
            this.checkBw2.TabIndex = 142;
            this.checkBw2.Text = "2";
            this.checkBw2.UseVisualStyleBackColor = true;
            // 
            // checkBw14
            // 
            this.checkBw14.AutoSize = true;
            this.checkBw14.Location = new System.Drawing.Point(53, 207);
            this.checkBw14.Name = "checkBw14";
            this.checkBw14.Size = new System.Drawing.Size(38, 17);
            this.checkBw14.TabIndex = 154;
            this.checkBw14.Text = "14";
            this.checkBw14.UseVisualStyleBackColor = true;
            // 
            // checkBw0
            // 
            this.checkBw0.AutoSize = true;
            this.checkBw0.Location = new System.Drawing.Point(6, 45);
            this.checkBw0.Name = "checkBw0";
            this.checkBw0.Size = new System.Drawing.Size(32, 17);
            this.checkBw0.TabIndex = 140;
            this.checkBw0.Text = "0";
            this.checkBw0.UseVisualStyleBackColor = true;
            // 
            // checkBw13
            // 
            this.checkBw13.AutoSize = true;
            this.checkBw13.Location = new System.Drawing.Point(53, 180);
            this.checkBw13.Name = "checkBw13";
            this.checkBw13.Size = new System.Drawing.Size(38, 17);
            this.checkBw13.TabIndex = 153;
            this.checkBw13.Text = "13";
            this.checkBw13.UseVisualStyleBackColor = true;
            // 
            // checkBw1
            // 
            this.checkBw1.AutoSize = true;
            this.checkBw1.Location = new System.Drawing.Point(6, 72);
            this.checkBw1.Name = "checkBw1";
            this.checkBw1.Size = new System.Drawing.Size(32, 17);
            this.checkBw1.TabIndex = 141;
            this.checkBw1.Text = "1";
            this.checkBw1.UseVisualStyleBackColor = true;
            // 
            // checkBw12
            // 
            this.checkBw12.AutoSize = true;
            this.checkBw12.Location = new System.Drawing.Point(53, 153);
            this.checkBw12.Name = "checkBw12";
            this.checkBw12.Size = new System.Drawing.Size(38, 17);
            this.checkBw12.TabIndex = 152;
            this.checkBw12.Text = "12";
            this.checkBw12.UseVisualStyleBackColor = true;
            // 
            // checkBw3
            // 
            this.checkBw3.AutoSize = true;
            this.checkBw3.Location = new System.Drawing.Point(6, 126);
            this.checkBw3.Name = "checkBw3";
            this.checkBw3.Size = new System.Drawing.Size(32, 17);
            this.checkBw3.TabIndex = 143;
            this.checkBw3.Text = "3";
            this.checkBw3.UseVisualStyleBackColor = true;
            // 
            // checkBw11
            // 
            this.checkBw11.AutoSize = true;
            this.checkBw11.Location = new System.Drawing.Point(53, 126);
            this.checkBw11.Name = "checkBw11";
            this.checkBw11.Size = new System.Drawing.Size(38, 17);
            this.checkBw11.TabIndex = 151;
            this.checkBw11.Text = "11";
            this.checkBw11.UseVisualStyleBackColor = true;
            // 
            // checkBw4
            // 
            this.checkBw4.AutoSize = true;
            this.checkBw4.Location = new System.Drawing.Point(6, 153);
            this.checkBw4.Name = "checkBw4";
            this.checkBw4.Size = new System.Drawing.Size(32, 17);
            this.checkBw4.TabIndex = 144;
            this.checkBw4.Text = "4";
            this.checkBw4.UseVisualStyleBackColor = true;
            // 
            // checkBw10
            // 
            this.checkBw10.AutoSize = true;
            this.checkBw10.Location = new System.Drawing.Point(53, 99);
            this.checkBw10.Name = "checkBw10";
            this.checkBw10.Size = new System.Drawing.Size(38, 17);
            this.checkBw10.TabIndex = 150;
            this.checkBw10.Text = "10";
            this.checkBw10.UseVisualStyleBackColor = true;
            // 
            // checkBw5
            // 
            this.checkBw5.AutoSize = true;
            this.checkBw5.Location = new System.Drawing.Point(6, 180);
            this.checkBw5.Name = "checkBw5";
            this.checkBw5.Size = new System.Drawing.Size(32, 17);
            this.checkBw5.TabIndex = 145;
            this.checkBw5.Text = "5";
            this.checkBw5.UseVisualStyleBackColor = true;
            // 
            // checkBw9
            // 
            this.checkBw9.AutoSize = true;
            this.checkBw9.Location = new System.Drawing.Point(53, 72);
            this.checkBw9.Name = "checkBw9";
            this.checkBw9.Size = new System.Drawing.Size(32, 17);
            this.checkBw9.TabIndex = 149;
            this.checkBw9.Text = "9";
            this.checkBw9.UseVisualStyleBackColor = true;
            // 
            // checkBw6
            // 
            this.checkBw6.AutoSize = true;
            this.checkBw6.Location = new System.Drawing.Point(6, 207);
            this.checkBw6.Name = "checkBw6";
            this.checkBw6.Size = new System.Drawing.Size(32, 17);
            this.checkBw6.TabIndex = 146;
            this.checkBw6.Text = "6";
            this.checkBw6.UseVisualStyleBackColor = true;
            // 
            // checkBw8
            // 
            this.checkBw8.AutoSize = true;
            this.checkBw8.Location = new System.Drawing.Point(53, 45);
            this.checkBw8.Name = "checkBw8";
            this.checkBw8.Size = new System.Drawing.Size(32, 17);
            this.checkBw8.TabIndex = 148;
            this.checkBw8.Text = "8";
            this.checkBw8.UseVisualStyleBackColor = true;
            // 
            // checkBw7
            // 
            this.checkBw7.AutoSize = true;
            this.checkBw7.Location = new System.Drawing.Point(6, 234);
            this.checkBw7.Name = "checkBw7";
            this.checkBw7.Size = new System.Drawing.Size(32, 17);
            this.checkBw7.TabIndex = 147;
            this.checkBw7.Text = "7";
            this.checkBw7.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label36.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label36.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label36.Location = new System.Drawing.Point(684, 45);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(22, 13);
            this.label36.TabIndex = 146;
            this.label36.Text = "3";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label37.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label37.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label37.Location = new System.Drawing.Point(684, 59);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(22, 13);
            this.label37.TabIndex = 145;
            this.label37.Text = "5";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label38.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label38.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label38.Location = new System.Drawing.Point(660, 59);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(23, 13);
            this.label38.TabIndex = 144;
            this.label38.Text = "4";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label39.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label39.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label39.Location = new System.Drawing.Point(660, 45);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(23, 13);
            this.label39.TabIndex = 143;
            this.label39.Text = "2";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label35.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label35.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label35.Location = new System.Drawing.Point(614, 45);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(45, 27);
            this.label35.TabIndex = 142;
            this.label35.Text = "1";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label34.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label34.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label34.Location = new System.Drawing.Point(614, 16);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(92, 28);
            this.label34.TabIndex = 80;
            this.label34.Text = "0";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label33.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label33.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label33.Location = new System.Drawing.Point(520, 45);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(22, 13);
            this.label33.TabIndex = 79;
            this.label33.Text = "2";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label32.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label32.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label32.Location = new System.Drawing.Point(520, 59);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(22, 13);
            this.label32.TabIndex = 78;
            this.label32.Text = "4";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label31.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label31.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label31.Location = new System.Drawing.Point(496, 59);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(23, 13);
            this.label31.TabIndex = 77;
            this.label31.Text = "3";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label30.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label30.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label30.Location = new System.Drawing.Point(496, 45);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 13);
            this.label30.TabIndex = 76;
            this.label30.Text = "1";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label29.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label29.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label29.Location = new System.Drawing.Point(543, 45);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(45, 27);
            this.label29.TabIndex = 75;
            this.label29.Text = "5";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label28.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label28.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label28.Location = new System.Drawing.Point(496, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 28);
            this.label28.TabIndex = 74;
            this.label28.Text = "0";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label27.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label27.Location = new System.Drawing.Point(375, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(92, 27);
            this.label27.TabIndex = 73;
            this.label27.Text = "2";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label26.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label26.Location = new System.Drawing.Point(422, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 28);
            this.label26.TabIndex = 72;
            this.label26.Text = "1";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label25.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label25.Location = new System.Drawing.Point(375, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 28);
            this.label25.TabIndex = 71;
            this.label25.Text = "0";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label24.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label24.Location = new System.Drawing.Point(307, 45);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 27);
            this.label24.TabIndex = 70;
            this.label24.Text = "2";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label23.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label23.Location = new System.Drawing.Point(260, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 27);
            this.label23.TabIndex = 69;
            this.label23.Text = "1";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label22.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label22.Location = new System.Drawing.Point(260, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 28);
            this.label22.TabIndex = 68;
            this.label22.Text = "0";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label21.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label21.Location = new System.Drawing.Point(142, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 27);
            this.label21.TabIndex = 67;
            this.label21.Text = "1";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label20.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label20.Location = new System.Drawing.Point(142, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 28);
            this.label20.TabIndex = 66;
            this.label20.Text = "0";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 56);
            this.label1.TabIndex = 65;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.Enabled = false;
            this.radioButton25.Location = new System.Drawing.Point(476, 330);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(14, 13);
            this.radioButton25.TabIndex = 64;
            this.radioButton25.TabStop = true;
            this.radioButton25.UseVisualStyleBackColor = true;
            this.radioButton25.CheckedChanged += new System.EventHandler(this.radioButton25_CheckedChanged);
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.Enabled = false;
            this.radioButton24.Location = new System.Drawing.Point(358, 330);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(14, 13);
            this.radioButton24.TabIndex = 63;
            this.radioButton24.TabStop = true;
            this.radioButton24.UseVisualStyleBackColor = true;
            this.radioButton24.CheckedChanged += new System.EventHandler(this.radioButton24_CheckedChanged);
            // 
            // radioButton23
            // 
            this.radioButton23.AutoSize = true;
            this.radioButton23.Enabled = false;
            this.radioButton23.Location = new System.Drawing.Point(240, 330);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(14, 13);
            this.radioButton23.TabIndex = 62;
            this.radioButton23.TabStop = true;
            this.radioButton23.UseVisualStyleBackColor = true;
            this.radioButton23.CheckedChanged += new System.EventHandler(this.radioButton23_CheckedChanged);
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.Enabled = false;
            this.radioButton22.Location = new System.Drawing.Point(122, 330);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(14, 13);
            this.radioButton22.TabIndex = 61;
            this.radioButton22.TabStop = true;
            this.radioButton22.UseVisualStyleBackColor = true;
            this.radioButton22.CheckedChanged += new System.EventHandler(this.radioButton22_CheckedChanged);
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Enabled = false;
            this.radioButton21.Location = new System.Drawing.Point(594, 240);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(14, 13);
            this.radioButton21.TabIndex = 60;
            this.radioButton21.TabStop = true;
            this.radioButton21.UseVisualStyleBackColor = true;
            this.radioButton21.CheckedChanged += new System.EventHandler(this.radioButton21_CheckedChanged);
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Enabled = false;
            this.radioButton20.Location = new System.Drawing.Point(476, 240);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(14, 13);
            this.radioButton20.TabIndex = 54;
            this.radioButton20.TabStop = true;
            this.radioButton20.UseVisualStyleBackColor = true;
            this.radioButton20.CheckedChanged += new System.EventHandler(this.radioButton20_CheckedChanged);
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Enabled = false;
            this.radioButton19.Location = new System.Drawing.Point(358, 240);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(14, 13);
            this.radioButton19.TabIndex = 53;
            this.radioButton19.TabStop = true;
            this.radioButton19.UseVisualStyleBackColor = true;
            this.radioButton19.CheckedChanged += new System.EventHandler(this.radioButton19_CheckedChanged);
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Enabled = false;
            this.radioButton18.Location = new System.Drawing.Point(240, 241);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(14, 13);
            this.radioButton18.TabIndex = 52;
            this.radioButton18.TabStop = true;
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton18.CheckedChanged += new System.EventHandler(this.radioButton18_CheckedChanged);
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Enabled = false;
            this.radioButton17.Location = new System.Drawing.Point(122, 241);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(14, 13);
            this.radioButton17.TabIndex = 51;
            this.radioButton17.TabStop = true;
            this.radioButton17.UseVisualStyleBackColor = true;
            this.radioButton17.CheckedChanged += new System.EventHandler(this.radioButton17_CheckedChanged);
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Enabled = false;
            this.radioButton16.Location = new System.Drawing.Point(594, 159);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(14, 13);
            this.radioButton16.TabIndex = 50;
            this.radioButton16.TabStop = true;
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.CheckedChanged += new System.EventHandler(this.radioButton16_CheckedChanged);
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Enabled = false;
            this.radioButton15.Location = new System.Drawing.Point(476, 159);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(14, 13);
            this.radioButton15.TabIndex = 44;
            this.radioButton15.TabStop = true;
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.radioButton15_CheckedChanged);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Enabled = false;
            this.radioButton14.Location = new System.Drawing.Point(358, 159);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(14, 13);
            this.radioButton14.TabIndex = 43;
            this.radioButton14.TabStop = true;
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton14_CheckedChanged);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Enabled = false;
            this.radioButton13.Location = new System.Drawing.Point(240, 160);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(14, 13);
            this.radioButton13.TabIndex = 42;
            this.radioButton13.TabStop = true;
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Enabled = false;
            this.radioButton12.Location = new System.Drawing.Point(122, 160);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(14, 13);
            this.radioButton12.TabIndex = 41;
            this.radioButton12.TabStop = true;
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Enabled = false;
            this.radioButton11.Location = new System.Drawing.Point(594, 89);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(14, 13);
            this.radioButton11.TabIndex = 40;
            this.radioButton11.TabStop = true;
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Enabled = false;
            this.radioButton10.Location = new System.Drawing.Point(476, 89);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(14, 13);
            this.radioButton10.TabIndex = 34;
            this.radioButton10.TabStop = true;
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Enabled = false;
            this.radioButton9.Location = new System.Drawing.Point(358, 90);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(14, 13);
            this.radioButton9.TabIndex = 33;
            this.radioButton9.TabStop = true;
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Enabled = false;
            this.radioButton8.Location = new System.Drawing.Point(240, 90);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(14, 13);
            this.radioButton8.TabIndex = 32;
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Enabled = false;
            this.radioButton7.Location = new System.Drawing.Point(122, 90);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(14, 13);
            this.radioButton7.TabIndex = 31;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Enabled = false;
            this.radioButton6.Location = new System.Drawing.Point(594, 16);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 13);
            this.radioButton6.TabIndex = 30;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Enabled = false;
            this.radioButton5.Location = new System.Drawing.Point(476, 16);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(358, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(240, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(122, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(4, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.comboResMonitor);
            this.Controls.Add(this.label2);
            this.Name = "clientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboResMonitor;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton25;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.RadioButton radioButton23;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.CheckBox checkBw0;
        private System.Windows.Forms.CheckBox checkBw15;
        private System.Windows.Forms.CheckBox checkBw14;
        private System.Windows.Forms.CheckBox checkBw13;
        private System.Windows.Forms.CheckBox checkBw12;
        private System.Windows.Forms.CheckBox checkBw11;
        private System.Windows.Forms.CheckBox checkBw10;
        private System.Windows.Forms.CheckBox checkBw9;
        private System.Windows.Forms.CheckBox checkBw8;
        private System.Windows.Forms.CheckBox checkBw7;
        private System.Windows.Forms.CheckBox checkBw6;
        private System.Windows.Forms.CheckBox checkBw5;
        private System.Windows.Forms.CheckBox checkBw4;
        private System.Windows.Forms.CheckBox checkBw3;
        private System.Windows.Forms.CheckBox checkBw2;
        private System.Windows.Forms.CheckBox checkBw1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.Label label189;
        private System.Windows.Forms.Label label190;
        private System.Windows.Forms.Label label191;
        private System.Windows.Forms.Label label192;
        private System.Windows.Forms.Label label193;
        private System.Windows.Forms.Label label194;
        private System.Windows.Forms.Label label195;
        private System.Windows.Forms.Label label197;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label177;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label218;
        private System.Windows.Forms.Label label219;
        private System.Windows.Forms.Label label220;
        private System.Windows.Forms.Label label221;
        private System.Windows.Forms.Label label226;
        private System.Windows.Forms.Label label227;
        private System.Windows.Forms.Label label228;
        private System.Windows.Forms.Label label229;
        private System.Windows.Forms.Label label214;
        private System.Windows.Forms.Label label215;
        private System.Windows.Forms.Label label216;
        private System.Windows.Forms.Label label217;
        private System.Windows.Forms.Label label222;
        private System.Windows.Forms.Label label223;
        private System.Windows.Forms.Label label224;
        private System.Windows.Forms.Label label225;
        private System.Windows.Forms.Label label201;
        private System.Windows.Forms.Label label202;
        private System.Windows.Forms.Label label203;
        private System.Windows.Forms.Label label204;
        private System.Windows.Forms.Label label205;
        private System.Windows.Forms.Label label206;
        private System.Windows.Forms.Label label207;
        private System.Windows.Forms.Label label208;
        private System.Windows.Forms.Label label209;
        private System.Windows.Forms.Label label210;
        private System.Windows.Forms.Label label211;
        private System.Windows.Forms.Label label212;
        private System.Windows.Forms.Label label213;
        private System.Windows.Forms.Label label196;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.RadioButton radioButton26;
    }
}

