namespace LifePathNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        string file = "�ͩR�F��.txt";


        private void button1_Click(object sender, EventArgs e)
        {
            DateTime yourday = dateTimePicker1.Value;
            string year = yourday.ToString("yyyyMMdd");
            int month = yourday.Month;
            int day = yourday.Day;
            var years = year.Select(x => int.Parse(x.ToString())).ToList();//�|�����o��>[2,0,2,5,0,9,0,1] Count=8

            int total = years.Sum();//���쪺����[�_��


            while (total > 9) //�褸�~���ۥ[�j��9�N�n�~��ۥ[(���F��)
            {
                var sum = total.ToString().Select(x => int.Parse(x.ToString())).ToList();
                total = sum.Sum(); //�o��O���s���w��>>���ΦA�ŧi���O
               

            }
            //�P�_�P�y
            string constellation = "";
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                constellation = "�d�Ϯy";
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                constellation = "�����y";
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 21))
                constellation = "���l�y";
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
                constellation = "���ɮy";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                constellation = "��l�y";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                constellation = "�B�k�y";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 23))
                constellation = "�ѯ��y";
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 21))
                constellation = "���Ȯy";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                constellation = "�g��y";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                constellation = "�]�~�y";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                constellation = "���~�y";
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
                constellation = "�����y";

            //Ū��file����ƨåB��ťզ�z��
            List<string> files = File.ReadAllLines(file)
                         .Select(x => x.Trim()) //�װű��C���r�e�᪺�ť�
                         .Where(x => !string.IsNullOrEmpty(x))
                         .ToList();

            var starsigns = new Dictionary<string, int>() 
            {
                { "�d�Ϯy", 0 }, { "�����y", 1 }, { "���l�y", 2 }, { "���ɮy", 3 }, { "��l�y", 4 }, { "�B�k�y", 5 },
                { "�ѯ��y", 6 }, { "���Ȯy", 7 }, { "�g��y", 8 }, { "�]�~�y", 9 }, { "���~�y", 10 }, { "�����y", 11 }
            };


            //label2.Text = $"�A���P�y�O�G{constellation}";
            string message = $"�A���P�y�O�G{constellation}\n�A���ͩR�F�ƬO�G{total}\n";

            foreach (var item in starsigns)
            {
                if (item.Key == constellation)
                {
                    int superstar =( item.Value * 10 )+ total;

                    if (superstar < files.Count)
                    {
                        message += files[superstar];
                    }
                    else
                    {
                        message += "�]�䤣��������e�^";
                    }
                    break; // ���������N���}
                }
            }

            
            if (!starsigns.ContainsKey(constellation))
            {
                message += "�]�S���o�ӬP�y�ա^";
            }

            // ��ܵ��G
            label2.Text = message.Replace("\n", Environment.NewLine);
        }

    }
}





