namespace ContentReplacement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個大於90的正整數:");
            var max = int.Parse(Console.ReadLine());
           if (max <= 90)
            {
                Console.WriteLine("錯誤!請輸入大於90的數字!");
                 return;
            }

            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Dann");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("School");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}