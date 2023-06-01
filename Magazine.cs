using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice7
{
    internal class Magazine : Edition
    {
        public Magazine(string name, int articles) : base(name)
        {
            _articles = articles;
        }
        public int _articles { get; set; }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"кол-во статей : {_articles}");
        }
    }
}
