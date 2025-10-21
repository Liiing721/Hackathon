namespace LifePathNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string file = "生命靈數.txt";
       

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime yourday = dateTimePicker1.Value;
            string year = yourday.ToString("yyyyMMdd");
            int month = yourday.Month;
            int day = yourday.Day;
            var years = year.Select(x => int.Parse(x.ToString())).ToList();//會長成這樣>[2,0,2,5,0,9,0,1] Count=8

            int total = years.Sum();//把選到的日期加起來
           
            var total2 = total;
            while (total > 9) //西元年月日相加大於9就要繼續相加 [2,0,2,5,0,9,0,1]>19>10>1
            {
                var sum = total.ToString().Select(x => int.Parse(x.ToString())).ToList();
                total = sum.Sum(); //這邊是重新指定值>>不用再宣告型別 宣告了會有紅色毛毛蟲
                label2.Text = $"年月日數字總和：{total}";

            }
           
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
