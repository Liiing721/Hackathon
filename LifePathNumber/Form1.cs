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
           
            var total2 = total;
            while (total > 9) //�褸�~���ۥ[�j��9�N�n�~��ۥ[ [2,0,2,5,0,9,0,1]>19>10>1
            {
                var sum = total.ToString().Select(x => int.Parse(x.ToString())).ToList();
                total = sum.Sum(); //�o��O���s���w��>>���ΦA�ŧi���O �ŧi�F�|����������
                label2.Text = $"�~���Ʀr�`�M�G{total}";

            }
           
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
