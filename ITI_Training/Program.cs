using System.Runtime.ExceptionServices;
using System.Timers;

namespace ITI_Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
    }
}
