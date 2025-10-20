namespace NumberGames
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
            startBtn = new Button();
            showansBtn = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            byeBtn = new Button();
            label2 = new Label();
            checkBtn = new Button();
            SuspendLayout();
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.FromArgb(255, 224, 192);
            startBtn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 136);
            startBtn.Location = new Point(72, 36);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(124, 49);
            startBtn.TabIndex = 0;
            startBtn.Text = "開始遊戲";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // showansBtn
            // 
            showansBtn.BackColor = Color.FromArgb(192, 255, 192);
            showansBtn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 136);
            showansBtn.Location = new Point(72, 120);
            showansBtn.Name = "showansBtn";
            showansBtn.Size = new Size(124, 49);
            showansBtn.TabIndex = 1;
            showansBtn.Text = "看答案";
            showansBtn.UseVisualStyleBackColor = false;
            showansBtn.Click += showansBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(72, 265);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 2;
            label1.Text = "輸入";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.MenuBar;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(517, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(255, 326);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Location = new Point(72, 291);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 30);
            textBox1.TabIndex = 4;
            // 
            // byeBtn
            // 
            byeBtn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 136);
            byeBtn.Location = new Point(201, 337);
            byeBtn.Name = "byeBtn";
            byeBtn.Size = new Size(104, 49);
            byeBtn.TabIndex = 6;
            byeBtn.Text = "放棄重來";
            byeBtn.UseVisualStyleBackColor = true;
            byeBtn.Click += byeBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGoldenrodYellow;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(517, 52);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 7;
            label2.Text = "遊戲歷程";
            // 
            // checkBtn
            // 
            checkBtn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 136);
            checkBtn.Location = new Point(72, 337);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(104, 49);
            checkBtn.TabIndex = 8;
            checkBtn.Text = "檢查答案";
            checkBtn.UseVisualStyleBackColor = true;
            checkBtn.Click += checkBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(checkBtn);
            Controls.Add(label2);
            Controls.Add(byeBtn);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(showansBtn);
            Controls.Add(startBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startBtn;
        private Button showansBtn;
        private Label label1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button byeBtn;
        private Label label2;
        private Button checkBtn;
    }
}
