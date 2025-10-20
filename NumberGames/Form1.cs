using System;

namespace NumberGames
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        public static class RandomData //static>群體的資料
        {
            public static string MyRandom { get; set; } = string.Empty; //宣告同時給初始值(不然參考型別可能為nulll)
        }

        public void RndData() //放外面大家一起用 寫在btn裡面會怪怪的
        {
            Random rand = new Random();
            List<int> rnd = new List<int>();


            for (int i = 0; i < 4; i++)
            {
                int num = rand.Next(0, 10);

                while (rnd.Contains(num)) //一直抽直到數字不重複
                {

                    num = rand.Next(0, 10);
                }

                rnd.Add(num);
            }


            RandomData.MyRandom = string.Join("", rnd); //把生出來的變數存進去RandomData裡面的MyRandom>>ex[1,2,3,4]>"1234"
        }



        private void startBtn_Click(object sender, EventArgs e)
        {
            RndData();
            MessageBox.Show("Game Srart!");
            startBtn.Enabled = false;


        }

        private void showansBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"答案是{RandomData.MyRandom}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            var check = RandomData.MyRandom;
            List<int> randomList = check.Select(x => int.Parse(x.ToString())).ToList();

            //var userinput =textBox1.Text;
            string input = textBox1.Text;

            var list = new List<int>();
            list = input.Select(x => int.Parse(x.ToString())).ToList();//要一個一個拿出來才對

           /* int number = int.Parse(textBox1.Text);
            List<int> list = new List<int>();
            list.Add(number); 這個寫法會報錯 >list只有一行(number)迴圈迴不起來??*/

            int A = 0; int B = 0;
            for (int i = 0;i < list.Count;i++)  //i是索引>比位置要從0開始 從1開始好像永遠都不會對???
            {
                if (list[i] == randomList[i]) //逐一檢查每個位子
                {
                    A++; // 同位置同數字>>>A
                }
                else if (randomList.Contains(list[i]))

                {
                    B++; // 不同位置但答案有「包含」這個數字>>>B
                }
            }
            listBox1.Items.Add($"{input}: {A}A{B}B");
            if(A==4)
            {
                MessageBox.Show("過關啦!!"); 
            }


        }

        private void byeBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            //listBox1.Items = string.Empty;
            listBox1.Items.Clear();
            startBtn.Enabled = true;
            MessageBox.Show("可以重新開始遊戲囉~");
        }
    }
}
 
