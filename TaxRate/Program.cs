namespace TaxRate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入你的年收入:");
            var input = decimal.Parse(Console.ReadLine());












            //Console.WriteLine($"應繳的金額為{Taxes(input)}元");

            
            
            //static decimal Taxes(decimal input)
            //{

            //    decimal Tax = 0;
            //    if (input > 0 && input <= 540000)
            //    {
            //        Tax = input * (decimal)0.05;

            //    }
            //    else if (input >= 540001 && input <= 1210000)
            //    {
            //        Tax = 540000 * (decimal)0.05 + (input - 540000) * (decimal)0.12; //前面的稅全部繳+多出來的部分乘上這個級距
            //    }
            //    else if (input >= 1210001 && input <= 2420000)
            //    {
            //        Tax = 540000 * (decimal)0.05 + (1210000 - 540000) * (decimal)0.12 + (input - 1210000) * (decimal)0.2;
            //    }
            //    else if (input >= 2420001 && input <= 4530000)
            //    {
            //        Tax = 540000 * (decimal)0.05 + (1210000 - 540000) * (decimal)0.12 + (2420000 - 1210000) * 0.20m
            //      + (input - 2420000) * (decimal)0.30;
            //    }
            //    else if (input >= 4530001 && input <= 10310000)
            //    {
            //        Tax = 540000 * (decimal)0.05 + (1210000 - 540000) * (decimal)0.12 + (2420000 - 1210000) * 0.20m
            //     + (4530000 - 2420000) * (decimal)0.30 + (input - 4530000) * (decimal)0.4;
            //    }
            //    else
            //    {
            //        Tax = 540000 * (decimal)0.05 + (1210000 - 540000) * (decimal)0.12 + (2420000 - 1210000) * 0.20m
            //     + (4530000 - 2420000) * (decimal)0.30 + (10310000 - 4530000) * (decimal)0.4 + (input - 10310000) * (decimal)0.5;
            //    }
            //    return Tax;
            //}
            
        }
    }
}