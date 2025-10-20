using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace NumberOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一句有意義的英文句子:");
            var input = Console.ReadLine();
            var clear = Regex.Split(input, @"[^A-Za-z]+");//去掉非字母的東東

            //var words = input.Split(' ');
            /*以空白分割
            but不能去掉標點符號???*/
            //var n = (input,@"[A-Za-z]+"); //不能丟進where 會怪怪的

            var group = clear.Where(x => !string.IsNullOrEmpty(x)) //篩選不是空的就進來分組
                             .GroupBy(x => x, StringComparer.OrdinalIgnoreCase);//分組時將大小寫視為一樣

            foreach (var word in group)
            {
            
                Console.WriteLine($"單字：{word.Key} 出現 {word.Count()} 次");
            }
        }
    }
}