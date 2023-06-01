using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice7
{
    internal class Book : Edition
    {
        public Book(string name, string author) : base(name)
        {
            _author = author;
        }
        public string _author { get; set; }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"автор : {_author}");
        }
    }
}
