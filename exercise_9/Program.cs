using System;

namespace exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сделайте сумму которую хотите перевести в валюту");
            double rate = double.Parse(Console.ReadLine());
            Console.WriteLine("выберите валюту: 1-гривны, 2-долары, 3-евро");
            int currency = int.Parse(Console.ReadLine());
            if (currency == 1)
            {
                Console.WriteLine($"доларры: {rate* 0.042}");
                Console.WriteLine($"евро: {rate*0.038}");
            }
            else if (currency == 2)
            {
                Console.WriteLine($"гривны: {rate * 23.5}");
                Console.WriteLine($"евро: {rate * 0.9}");
            }
            else
            {
                Console.WriteLine($"гривны: {rate * 25.85}");
                Console.WriteLine($"доллары: {rate * 1.11}");
            }
        }
    }
}
