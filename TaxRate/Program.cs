namespace TaxRate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入你的年收入:");
            var input = decimal.Parse(Console.ReadLine());
            var taxRates = new List<MyTaxRate>
            {
                new MyTaxRate{ Min=0, Max=540000, Rate=0.05m},
                new MyTaxRate{ Min=540000, Max=1210000, Rate=0.12m},
                new MyTaxRate{ Min=1210000, Max=2420000, Rate=0.20m},
                new MyTaxRate{ Min=2420000, Max=4530000, Rate=0.30m},
                new MyTaxRate{ Min=4530000, Max=10310000, Rate=0.40m},
                new MyTaxRate{ Min=10310000, Max=decimal.MaxValue, Rate=0.50m},
            };
            decimal tax = 0;
            foreach (var rate in taxRates)
            {
                if (input > rate.Min) //如果收入比區間的min還多才計算
                {
                    var taxs = Math.Min(input, rate.Max) - rate.Min;//Math.Min(a,b)>>取a,b中較小的值(算出差額)
                    tax += taxs * rate.Rate; //差額*趴數然後累加
                }
                else //如果收入比後面區間的min還少就不用往下算了
                {
                    break;
                }
            }
            Console.WriteLine($"應繳的金額為{tax}元");




            

        }
    }
}