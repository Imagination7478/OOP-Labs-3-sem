using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_1 {
    class Rational {
        private int d, n; //n - числитель, d - знаменатель

       public Rational(int n, int d)
        {
            this.d = d;
            this.n = n;
        }
        public int GetD()
        {
            return d;
        }
        public int GetN()
        {
            return n;
        }
        public void Show() {
            Console.Write(d + "/" + n);
        }
    }
}
