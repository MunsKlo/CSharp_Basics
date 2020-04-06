using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class Task
    {
        public string LETTER
        {
            get
            {
                return letter;
            }
            set
            {
                letter = value;
            }
        }
        public string DESCRIPTION
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public delegate void Method();
        public Method MainMethod;
        private string letter;
        private string description;
        

        public Task(string _letter, string _description, Action newMethod)
        {
            letter = _letter;
            description = _description;
            MainMethod = new Method(newMethod);
        }
    }
}
