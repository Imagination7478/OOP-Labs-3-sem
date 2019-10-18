using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_1
{
    class Polynom
    {
        SetOfRational rSet;
        List<char> unknown;
        Polynom(SetOfRational rSet) {
            for (int i = 0; i < rSet.Size(); i++) {
                this.rSet = rSet;
                Console.Write("Input unknown for ");
                rSet[i].Show();
                char u = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                this.unknown[i] = u;
            }
        }
        Polynom(SetOfRational rSet, List<char> unknown)
        {
            for (int i = 0; i < rSet.Size(); i++)
            {
                this.rSet = rSet;
                this.unknown[i] = unknown[i];
            }
        }

        //Polynom() { }

        public void Show() {
            for(int i = 0; i < rSet.Size(); i++) {
                rSet[i].Show();
                Console.Write(unknown[i]);
                if (i != 0) {
                    if (rSet[i].GetD() < 0) {
                        Console.Write(" - ");
                    }
                    else {
                        Console.Write(" + ");
                    }
                }
            }
            Console.WriteLine();
        }

        public static Polynom operator +(Polynom firstPol, Polynom secondPol) {
            int newSize;
            if (firstPol.rSet.Size() < secondPol.rSet.Size()) {
                newSize = secondPol.rSet.Size();
            } else {
                newSize = firstPol.rSet.Size();
            }

            SetOfRational rSet = new SetOfRational();
            List<char> unknown = new List<char>();

            for(int i = 0; i < newSize; i++) {
                rSet[i] = firstPol.rSet[i] + secondPol.rSet[i];
            }

            Polynom newP = new Polynom(rSet, unknown);
            return ;
        }
    }
}
