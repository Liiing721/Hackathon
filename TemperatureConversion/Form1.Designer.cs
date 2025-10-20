namespace TemperatureConversion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Convertbtn = new Button();
            Clearbtn = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btn1 = new Button();
            dotbtn = new Button();
            btn8 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            happy = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Convertbtn
            // 
            Convertbtn.BackColor = SystemColors.AppWorkspace;
            Convertbtn.Location = new Point(517, 219);
            Convertbtn.Name = "Convertbtn";
            Convertbtn.Size = new Size(101, 46);
            Convertbtn.TabIndex = 0;
            Convertbtn.Text = "轉換";
            Convertbtn.UseVisualStyleBackColor = false;
            Convertbtn.Click += Convert_Click;
            // 
            // Clearbtn
            // 
            Clearbtn.BackColor = SystemColors.AppWorkspace;
            Clearbtn.Location = new Point(674, 219);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(101, 46);
            Clearbtn.TabIndex = 1;
            Clearbtn.Text = "清除";
            Clearbtn.UseVisualStyleBackColor = false;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(517, 319);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 2;
            label1.Text = "結果:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientActiveCaption;
            textBox1.Location = new Point(506, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 30);
            textBox1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(12, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 152);
            panel1.TabIndex = 4;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(45, 86);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(161, 26);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "華氏轉換為攝氏";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(45, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(161, 26);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "攝氏轉換為華氏";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlDarkDark;
            btn1.Location = new Point(301, 76);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 51);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Btn1_Click;
            // 
            // dotbtn
            // 
            dotbtn.BackColor = SystemColors.ActiveBorder;
            dotbtn.Location = new Point(367, 291);
            dotbtn.Name = "dotbtn";
            dotbtn.Size = new Size(60, 51);
            dotbtn.TabIndex = 6;
            dotbtn.Text = ".";
            dotbtn.UseVisualStyleBackColor = false;
            dotbtn.Click += Dotbtn_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlDarkDark;
            btn8.Location = new Point(367, 217);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 51);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Btn8_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlDarkDark;
            btn0.Location = new Point(301, 291);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 51);
            btn0.TabIndex = 8;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Btn0_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlDarkDark;
            btn9.Location = new Point(433, 219);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 51);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Btn9_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlDarkDark;
            btn7.Location = new Point(301, 219);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 51);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlDarkDark;
            btn6.Location = new Point(433, 150);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 51);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlDarkDark;
            btn5.Location = new Point(367, 150);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 51);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlDarkDark;
            btn4.Location = new Point(301, 150);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 51);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Btn4_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlDarkDark;
            btn3.Location = new Point(433, 76);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 51);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlDarkDark;
            btn2.Location = new Point(367, 76);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 51);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Btn2_Click;
            // 
            // happy
            // 
            happy.BackColor = Color.FromArgb(255, 255, 128);
            happy.FlatStyle = FlatStyle.Popup;
            happy.Location = new Point(433, 291);
            happy.Name = "happy";
            happy.Size = new Size(60, 51);
            happy.TabIndex = 16;
            happy.Text = "😆";
            happy.UseVisualStyleBackColor = false;
            happy.Click += Happy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(922, 543);
            Controls.Add(happy);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btn8);
            Controls.Add(dotbtn);
            Controls.Add(btn1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Clearbtn);
            Controls.Add(Convertbtn);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Convertbtn;
        private Button Clearbtn;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private Button btn1;
        private Button dotbtn;
        private Button btn8;
        private Button btn0;
        private Button btn9;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button happy;
    }
}
