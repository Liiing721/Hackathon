namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Convert_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                if (double.TryParse(textBox1.Text, out double celsius))
                {
                    double fahrenheit = (celsius * 9.0 / 5.0) + 32;
                    label1.Text = $"結果:{celsius}°C為{fahrenheit}°F";
                }
                else
                {
                    label1.Text = "請輸入攝氏溫度!";
                }
            }

            if (radioButton2.Checked == true)
            {
                if (double.TryParse(textBox1.Text, out double fahrenheit))
                {
                    double celsius = (fahrenheit - 32.0) * 5.0 / 9.0;
                    label1.Text = $"結果:{fahrenheit}°F為{celsius}°C";
                }
                else
                {
                    label1.Text = "請輸入華氏溫度!";
                }
            }

            if (!radioButton1.Checked && !radioButton2.Checked )
            {
                MessageBox.Show("左側要記得選轉換方式喔");
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            label1.Text = string.Empty;

        }
        private void Clear()
        {
             if(textBox1.Text == "0")
            {
                textBox1.Text = string.Empty;
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = textBox1.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = textBox1.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = textBox1.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = textBox1.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = textBox1.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = textBox1.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Clear(); 
            textBox1.Text = textBox1.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = textBox1.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = textBox1.Text + "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = textBox1.Text + "0";
        }

        private void Dotbtn_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = textBox1.Text + ".";
        }

        //private void NumberBtn_Click(object sender, EventArgs e)
        //{
        //    Clear();

        //    Button clickedButton = (Button)sender;        把 sender 轉成 Button
        //    var buttonValueText = clickedButton.Text;     取出按鈕上的文字
        //    textBox1.Text = textBox1.Text + buttonValueText;
        //}
    }
}
