using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class Bot : Player
    {
        private string name;
        private Variables.GameOptions myOption;
        private int wins;
        public Bot(string _name)
        {
            NAME = _name;
        }
    }
}
