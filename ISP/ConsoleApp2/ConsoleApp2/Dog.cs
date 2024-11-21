using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Dog : Animal, ISound, IBark
    {
        public Dog(string name) : base(name) { }

        public override string MakeSound()
        {
            return Bark();
        }

        public string Bark()
        {
            return "Гав!";
        }
    }
}
