using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class Variables
    {
        public static List<Task> tasks = new List<Task>();
        public static List<string> letters = new List<string> { "a)", "b)", "c)", "d)", "e)", "f)" };
        public static List<string> descriptions = new List<string>
        {
            "von 0 - 99 alle ganzzahligen Werte auswirft.",
            "von 0 - 99 alle geraden Zahlen auswirft.",
            "von 0 bis 99 alle Zahlen auswirft, die sowohl durch 3 als auch durch 5 teilbar sind.",
            "von 0 bis n alle zunachst Primzahlen und abschließend die Anzahl der ausgegebenen Primzahlen ausgibt.",
            "Dezimalwerte im Wertebereich zwischen 0 – 999 einliest und daraufhin diese in das Dualsystem konvertiert ausgibt.",
            "Stein, Papier, Schere, Echse, Spock"
        };
        public static List<Action> methods = new List<Action>
        {
            TaskSolutions.TaskA,
            TaskSolutions.TaskB,
            TaskSolutions.TaskC,
            TaskSolutions.TaskD,
            TaskSolutions.TaskE,
            TaskSolutions.TaskF,
        };
        public static Dictionary<int, string> gameOptions = new Dictionary<int, string>()
        {
            { 1, "Schere" },
            { 2, "Stein" },
            { 3, "Papier"},
            { 4, "Echse"},
            { 5, "Spok"}
        };
           
        public enum GameOptions
        {
            Stein, Papier, Schere, Echse, Spok
        }

        public static List<string> BotNames = new List<string>
        {
            "Muffin",
            "Portge",
            "DerEineVonDort",
            "Noob4ever",
            "ReadySteadyGo"
        };
    }
}
