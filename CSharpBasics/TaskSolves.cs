using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class TaskSolves
    {
        public static void TaskA()
        {
            Console.Clear();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void TaskB()
        {
            Console.Clear();
            for (int i = 0; i < 100; i++)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void TaskC()
        {
            Console.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void TaskD()
        {
            Console.Clear();
            var numb = TaskInput("Write the maximum Number!");
            Console.Clear();
            Console.WriteLine($"Here are all prime numbers from {2} to {numb}");
            Console.WriteLine("0 and 1 are special cases, they dont count");
            for (int i = 2; i < Convert.ToInt32(numb); i++)
            {
                bool isPrimeNumber = true;
                for (int j = 2; j < i - 1; j++)
                {
                    if(i % j == 0 && i != j)
                    {
                        isPrimeNumber = false;
                    }
                }
                if(isPrimeNumber)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void TaskE()
        {
            Console.Clear();
            List<string> DecimalNumbs = FillDecimalList();
            
            Console.ReadLine();
        }

        public static void TaskF()
        {
            Console.Clear();
            Console.WriteLine("F");
            Console.ReadLine();
        }

        private static string TaskInput(string description)
        {
            while (true)
            {
                Console.WriteLine(description);
                if (int.TryParse(Console.ReadLine(), out int numb))
                    return numb.ToString();
            }
        }

        private static List<string> FillDecimalList()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i.ToString());
            }
            return list;
        }
    }
}
