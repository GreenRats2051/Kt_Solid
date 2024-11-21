using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Horse : Animal, ISound, IWhinny
    {
        public Horse(string name) : base(name) { }

        public override string MakeSound()
        {
            return Whinny();
        }

        public string Whinny()
        {
            return "Иго-го!";
        }
    }
}
