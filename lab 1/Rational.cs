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

        public static Rational operator +(Rational f, Rational s) {
            Rational newR;
            int newN1, newN2;
            if (f.GetD() == s.GetD()) {
                newR = new Rational(f.GetN() + s.GetN(), f.GetD() + s.GetD());
            }
            else {
                int noz = NOZ(new int[2] { f.GetD(), s.GetD() });
                newN1 = noz / f.GetD() * f.GetN();
                newN2 = noz / s.GetD() * s.GetN();
                newR = new Rational(newN1 + newN2, noz);
            }
            return newR;
        }

        private static int NOZ(int[] maxmin)
        {
            Array.Sort(maxmin);
            if (maxmin[1] % maxmin[0] == 0)
                return maxmin[1];

            int temp = 0;
            for (int i = 2; ; i++)
            {
                temp = maxmin[1] * i;
                if (temp % maxmin[0] == 0)
                {
                    break;
                }
            }
            return temp;
        }
    }
}
