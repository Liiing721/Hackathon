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


            while (total > 9) //西元年月日相加大於9就要繼續相加(算靈數)
            {
                var sum = total.ToString().Select(x => int.Parse(x.ToString())).ToList();
                total = sum.Sum(); //這邊是重新指定值>>不用再宣告型別
               

            }
            //判斷星座
            string constellation = "";
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                constellation = "牡羊座";
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                constellation = "金牛座";
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 21))
                constellation = "雙子座";
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
                constellation = "巨蟹座";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                constellation = "獅子座";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                constellation = "處女座";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 23))
                constellation = "天秤座";
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 21))
                constellation = "天蠍座";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                constellation = "射手座";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                constellation = "魔羯座";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                constellation = "水瓶座";
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
                constellation = "雙魚座";

            //讀取file的資料並且把空白行篩掉
            List<string> files = File.ReadAllLines(file)
                         .Select(x => x.Trim()) //修剪掉每行文字前後的空白
                         .Where(x => !string.IsNullOrEmpty(x))
                         .ToList();

            var starsigns = new Dictionary<string, int>() 
            {
                { "牡羊座", 0 }, { "金牛座", 1 }, { "雙子座", 2 }, { "巨蟹座", 3 }, { "獅子座", 4 }, { "處女座", 5 },
                { "天秤座", 6 }, { "天蠍座", 7 }, { "射手座", 8 }, { "魔羯座", 9 }, { "水瓶座", 10 }, { "雙魚座", 11 }
            };


            //label2.Text = $"你的星座是：{constellation}";
            string message = $"你的星座是：{constellation}\n你的生命靈數是：{total}\n";

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
                        message += "（找不到對應內容）";
                    }
                    break; // 找到對應的就離開
                }
            }

            
            if (!starsigns.ContainsKey(constellation))
            {
                message += "（沒有這個星座啦）";
            }

            // 顯示結果
            label2.Text = message.Replace("\n", Environment.NewLine);
        }

    }
}





