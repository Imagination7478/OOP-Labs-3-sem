using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_1
{
    class SetOfRational
    {
        List<Rational> set;
        Rational RationalNumber;
        double min = Double.MaxValue, max = Double.MinValue;
        Rational minr, maxr;

        public int Size() {
            return set.Count;
        }

        public void Add() {

            Console.WriteLine("Input numinator: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input denominator: ");
            int denom = Convert.ToInt32(Console.ReadLine());

            RationalNumber = new Rational(num, denom);

            FindMinMax(RationalNumber);

            set.Add(RationalNumber);
        }

        public void GetMin() {
            minr.Show();
        }

        public void GetMax() {
            maxr.Show();
        }

        public void FindMinMax(Rational rational) {
            double temp = CountUp(rational);
            if (temp < min) {
                min = temp;
                minr = rational;
            }
            if (temp > max) {
                max = temp;
                maxr = rational;
            }
        }

        public void GetBigger(Rational rational) {
            int quantity = 0;

            if (set.Count() == 0)
            {
                Console.WriteLine("Set is empty.");
            }
            else
            {
                double temp = CountUp(rational);
                for (int i = 0; i < set.Count(); ++i) {
                    if (temp > CountUp(set[i])) {
                        quantity++;
                    }
                }
                Console.Write("Have " + quantity + "rationals, that is bigger, than ");
                rational.Show();
            }
        }

        public void GetLower(Rational rational) {
            int quantity = 0;

            if (set.Count() == 0)
            {
                Console.WriteLine("Set is empty.");
            }
            else
            {
                double temp = CountUp(rational);
                for (int i = 0; i < set.Count(); ++i)
                {
                    if (temp < CountUp(set[i]))
                    {
                        quantity++;
                    }
                }
                Console.Write("Have " + quantity + "rationals, that is lower, than ");
                rational.Show();
            }
        }

        public double CountUp(Rational rational) {
            return (rational.GetN() / rational.GetD());
        }

        public void InputFromFile(string path) {
            try {
                StreamReader sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null) {
                    int n = Convert.ToInt32(line[0]);
                    int d = Convert.ToInt32(line[2]);
                    Rational rt = new Rational(n, d);

                    FindMinMax(rt);

                    set.Add(rt);
                }
            }
            catch (FileNotFoundException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public Rational this[int i] {
            get {
                return set[i];
            }
            set { }
            
        }
        
    }
}
