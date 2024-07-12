using System.Runtime.ExceptionServices;
using System.Timers;

namespace ITI_Training
{
    class student
    {
        int id;
        string name;
        int age;
        public void Print()
        {
            Console.WriteLine($"id : {id} - name : {name} - age : {age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region proplem 1
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
            #endregion
            #region proplem 2
            int id;
            int salary;
            int age;
            Console.Write("Enter the id : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter the salary : ");
            salary = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.Write("Enter the age ");
                age = int.Parse(Console.ReadLine());
                if (age > 0)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"""
                    {"Your id :"} {id}

                    {"Your salary :"} {salary}
                    
                    {"Your age :"} {age}
                    """);
            #endregion

            #region proplem 3
            student s = new student();
            s.Print();
            #endregion
        }
    }
}
