using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class TaskSolutions
    {
        public static Random random = new Random();
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
            var numb = TaskInput("Write the maximum Number!", "d");
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
            List<string> decimalNumbs = FillList();
            List<string> dualNumbs = FillList(decimalNumbs);
            for (int i = 0; i < dualNumbs.Count; i++)
            {
                Console.WriteLine(dualNumbs[i]);
            }
            Console.ReadLine();
        }

        public static void TaskF()
        {
            Console.Clear();
            PlayGame();
            Console.ReadLine();
        }

        private static string TaskInput(string description, string task)
        {
            if(task == "d")
            {
                while (true)
                {
                    Console.WriteLine(description);
                    if (int.TryParse(Console.ReadLine(), out int numb))
                        return numb.ToString();
                }
            }
            else if(task == "f")
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine(description);
                    Console.WriteLine();
                    foreach (var item in Variables.gameOptions)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                    if (Variables.gameOptions.TryGetValue(Convert.ToInt32(Console.ReadLine()), out string value))
                        return value;
                }
            }
            else
            {
                Console.WriteLine(description);
                return Console.ReadLine();
            }
            
        }

        private static List<string> FillList()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i.ToString());
            }
            return list;
        }

        private static List<string> FillList(List<string> decimalList)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < decimalList.Count; i++)
            {
                list.Add(ConvertDecimalToDual(decimalList[i]));
            }
            return list;
        }

        private static string ConvertDecimalToDual(string decimalString)
        {
            var decimalNumb = Convert.ToInt32(decimalString);
            var dualString = "";
            while (decimalNumb > 1)
            {
                if (decimalNumb % 2 == 0)
                    dualString += 0;
                else
                    dualString += 1;
                decimalNumb /= 2;
            }
            dualString += 1;
            var charArray = dualString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static void PlayGame()
        {
            var user = new User(TaskInput("What is your Username?", ""));
            var bot = new Bot(Variables.BotNames[random.Next(0, Variables.BotNames.Count)]);
            var input = "";
            while(input != "exit")
            {
                ShowHead(user, bot);
                user.SetGameOption(TaskInput("Choose your option.", "f"));
                bot.SetGameOption(Variables.gameOptions[random.Next(0, Variables.gameOptions.Count)]);
                Console.WriteLine($"{user.MYOPTION} | {bot.MYOPTION}");
                Console.WriteLine(AddWin(user, bot, WhoIsWinnerOfTheRound(user, bot)));
                Console.ReadKey();
                input = TaskInput("Leave the game? Write 'exit' to leave or something to continue.", "");
                Console.Clear();
            }
        }

        private static void ShowHead(User user, Bot bot)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Fight!");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Members:");
            Console.WriteLine($"{user.NAME} vs {bot.NAME}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Wins:");
            Console.WriteLine($"{user.NAME}: {user.WINS}");
            Console.WriteLine($"{bot.NAME}: {bot.WINS}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"{GetWinner(user, bot)} is leading!");
        }

        private static string GetWinner(User user, Bot bot)
        {
            if (user.WINS > bot.WINS)
                return $"{user.NAME} is winning!";
            else if (user.WINS < bot.WINS)
                return $"{bot.NAME} is winning!";
            else
                return "Draw!";
        }
        //0 = Unentschieden | 1 = User hat gewonnen | 2 = Bot hat gewonnen
        private static int WhoIsWinnerOfTheRound(User user, Bot bot)
        {
            if (user.MYOPTION == bot.MYOPTION)
                return 0;
            //Area
            if (user.MYOPTION == Variables.GameOptions.Stein)
            {
                if (bot.MYOPTION == Variables.GameOptions.Schere)
                    return 1;
                else if (bot.MYOPTION == Variables.GameOptions.Papier)
                    return 2;
                else if (bot.MYOPTION == Variables.GameOptions.Echse)
                    return 1;
                else if (bot.MYOPTION == Variables.GameOptions.Spok)
                    return 2;
            }
            //Area
            else if (user.MYOPTION == Variables.GameOptions.Schere)
            {
                if (bot.MYOPTION == Variables.GameOptions.Stein)
                    return 2;
                else if (bot.MYOPTION == Variables.GameOptions.Papier)
                    return 1;
                else if (bot.MYOPTION == Variables.GameOptions.Echse)
                    return 1;
                else if (bot.MYOPTION == Variables.GameOptions.Spok)
                    return 2;
            }
            //Area
            else if (user.MYOPTION == Variables.GameOptions.Papier)
            {
                if (bot.MYOPTION == Variables.GameOptions.Schere)
                    return 2;
                else if (bot.MYOPTION == Variables.GameOptions.Stein)
                    return 1;
                else if (bot.MYOPTION == Variables.GameOptions.Echse)
                    return 2;
                else if (bot.MYOPTION == Variables.GameOptions.Spok)
                    return 1;
            }
            //Area
            else if (user.MYOPTION == Variables.GameOptions.Echse)
            {
                if (bot.MYOPTION == Variables.GameOptions.Schere)
                    return 2;
                else if (bot.MYOPTION == Variables.GameOptions.Papier)
                    return 1;
                else if (bot.MYOPTION == Variables.GameOptions.Stein)
                    return 2;
                else if (bot.MYOPTION == Variables.GameOptions.Spok)
                    return 1;
            }
            //Area
            else if (user.MYOPTION == Variables.GameOptions.Spok)
            {
                if (bot.MYOPTION == Variables.GameOptions.Schere)
                    return 2;
                else if (bot.MYOPTION == Variables.GameOptions.Papier)
                    return 2;
                else if (bot.MYOPTION == Variables.GameOptions.Echse)
                    return 1;
                else if (bot.MYOPTION == Variables.GameOptions.Stein)
                    return 1;
            }
            return 0;
        }

        private static string AddWin(User user, Bot bot, int numb)
        {
            if (numb == 1)
            {
                user.WINS += 1;
                return $"{user.NAME} wins this round!";
            }
            else if (numb == 2)
            {
                bot.WINS += 1;
                return $"{bot.NAME} wins this round!";
            }
            else
                return "Draw!";
                
        }
    }
}
