using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            FillTasks();
            while (true)
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Welcome to CSharpBasics!");
                Console.WriteLine();
                try
                {
                    ShowMenu();
                    var task = GetTask(Input());
                    Output(task);
                }
                catch (Exception error)
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Something went wrong!");
                    Console.WriteLine($"The Error is: {error.Message}");
                    Console.WriteLine("If the Error is about a Index, who is out of range. Then you wrote the wrong letter! Write 'a)' for example to call the first task.");
                }
            }
        }

        private static void FillTasks()
        {
            for (int i = 0; i < Variables.letters.Count; i++)
            {
                Task newTask = new Task(Variables.letters[i], Variables.descriptions[i], Variables.methods[i]);
                Variables.tasks.Add(newTask);
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Choose the task! (Write the letter at the begin)");
            for (int i = 0; i < Variables.tasks.Count; i++)
            {
                var task = Variables.tasks[i];
                Console.WriteLine($"{task.LETTER} {task.DESCRIPTION}");
                Console.WriteLine();
            }
        }

        private static string Input()
        {
            Console.WriteLine("Write the letter of the topic!");
            return Console.ReadLine();
        }

        private static Task GetTask(string letters)
        {
            var numb = -1;
            for (int i = 0; i < Variables.tasks.Count; i++)
            {
                if (Variables.tasks[i].LETTER == letters)
                {
                    numb = i;
                }
            }
            return Variables.tasks[numb];
        }

        private static void Output(Task task)
        {
            task.MainMethod();
        }
    }
}
