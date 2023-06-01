using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice7
{
    abstract class Edition
    {
        public Edition(string name)
        {
            _name = name;
        }
        public string _name { get; set; }
        public Edition Next { get; set; }
        public Edition Prev { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"имя : {_name}");
        }
    }
}
