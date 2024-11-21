using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract string MakeSound();
        protected Animal(string name)
        {
            Name = name;
        }
    }
}
