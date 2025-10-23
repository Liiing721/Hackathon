namespace LifePathNumber
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
            label1 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 70);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 0;
            label1.Text = "請選擇生日:";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.PaleTurquoise;
            button1.Location = new Point(29, 238);
            button1.MaximumSize = new Size(4000, 0);
            button1.Name = "button1";
            button1.Size = new Size(133, 33);
            button1.TabIndex = 2;
            button1.Text = "分析結果";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(29, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 30);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.Value = new DateTime(2025, 9, 23, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Location = new Point(353, 114);
            label2.MaximumSize = new Size(400, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 4;
            label2.Text = "結果:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Location = new Point(353, 70);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 5;
            label3.Text = "關於你";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
    }
}
