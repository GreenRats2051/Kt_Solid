using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cat : Animal, ISound, IMew
    {
        public Cat(string name) : base(name) { }

        public override string MakeSound()
        {
            return Mew();
        }

        public string Mew()
        {
            return "Мяу!";
        }
    }
}
