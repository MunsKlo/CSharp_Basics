using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class User : Player
    {
        private string name;
        private Variables.GameOptions myOption;
        private int wins;
        public User(string _name)
        {
            NAME = _name;
        }
    }
}
