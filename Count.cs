using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabotai
{//
    class Count
    {
        public string name;
        public string shifr;
        public int sum;
        public Count()
        {
            this.name = "Изделие";
            this.shifr = "Poof";
            this.sum = 0;
        }
        public Count(string cName, string cShifr, int cSum)
        {
            this.name = cName;
            this.shifr = cShifr;
            this.sum = cSum;
        }
    }
}
