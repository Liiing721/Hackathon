using System;

namespace NumberGames
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        public static class RandomData //static>�s�骺���
        {
            public static string MyRandom { get; set; } = string.Empty; //�ŧi�P�ɵ���l��(���M�Ѧҫ��O�i�ରnulll)
        }

        public void RndData() //��~���j�a�@�_�� �g�bbtn�̭��|�ǩǪ�
        {
            Random rand = new Random();
            List<int> rnd = new List<int>();


            for (int i = 0; i < 4; i++)
            {
                int num = rand.Next(0, 10);

                while (rnd.Contains(num)) //�@���⪽��Ʀr������
                {

                    num = rand.Next(0, 10);
                }

                rnd.Add(num);
            }


            RandomData.MyRandom = string.Join("", rnd); //��ͥX�Ӫ��ܼƦs�i�hRandomData�̭���MyRandom>>ex[1,2,3,4]>"1234"
        }



        private void startBtn_Click(object sender, EventArgs e)
        {
            RndData();
            MessageBox.Show("Game Srart!");
            startBtn.Enabled = false;


        }

        private void showansBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"���׬O{RandomData.MyRandom}");
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
            list = input.Select(x => int.Parse(x.ToString())).ToList();//�n�@�Ӥ@�Ӯ��X�Ӥ~��

           /* int number = int.Parse(textBox1.Text);
            List<int> list = new List<int>();
            list.Add(number); �o�Ӽg�k�|���� >list�u���@��(number)�j��j���_��??*/

            int A = 0; int B = 0;
            for (int i = 0;i < list.Count;i++)  //i�O����>���m�n�q0�}�l �q1�}�l�n���û������|��???
            {
                if (list[i] == randomList[i]) //�v�@�ˬd�C�Ӧ�l
                {
                    A++; // �P��m�P�Ʀr>>>A
                }
                else if (randomList.Contains(list[i]))

                {
                    B++; // ���P��m�����צ��u�]�t�v�o�ӼƦr>>>B
                }
            }
            listBox1.Items.Add($"{input}: {A}A{B}B");
            if(A==4)
            {
                MessageBox.Show("�L����!!"); 
            }


        }

        private void byeBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            //listBox1.Items = string.Empty;
            listBox1.Items.Clear();
            startBtn.Enabled = true;
            MessageBox.Show("�i�H���s�}�l�C���o~");
        }
    }
}
 
