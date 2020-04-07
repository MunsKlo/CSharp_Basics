using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class Player
    {
        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Variables.GameOptions MYOPTION
        {
            get
            {
                return myOption;
            }
            set
            {
                myOption = value;
            }
        }
        public int WINS
        {
            get
            {
                return wins;
            }
            set
            {
                wins = value;
            }
        }
        private string name;
        private Variables.GameOptions myOption;
        private int wins;

        public void SetGameOption(string option)
        {
            if (option == "Schere")
                myOption = Variables.GameOptions.Schere;
            else if (option == "Stein")
                myOption = Variables.GameOptions.Stein;
            else if (option == "Papier")
                myOption = Variables.GameOptions.Papier;
            else if (option == "Echse")
                myOption = Variables.GameOptions.Echse;
            else if (option == "Spok")
                myOption = Variables.GameOptions.Spok;
        }
    }
}
