using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    class Searching
    {
        private string keyword;
        public Searching() { }

        public Searching(string _keyword)
        {
            Keyword = _keyword;
        }

        public string Keyword { get => keyword; set => keyword = value; }
    }
}
