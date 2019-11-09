using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_1
{
    class Polynom
    {
        SetOfRational rSet; // Дроби
        List<char> unknown; // их буквы

        // Создание полинома через консоль
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

        // Создание полинома из файла
        Polynom(SetOfRational rSet, List<char> unknown)
        {
            for (int i = 0; i < rSet.Size(); i++)
            {
                this.rSet = rSet;
                this.unknown[i] = unknown[i];
            }
        }

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

        // Сумма полиномов
        public static Polynom operator +(Polynom firstPol, Polynom secondPol)
        {
            for (int i = 0, j = 0; i < secondPol.unknown.Count(); i++)
            {
                if (secondPol.unknown[i] == firstPol.unknown[j])
                {
                    firstPol.rSet[i] = firstPol.rSet[i] + secondPol.rSet[i];
                    break;
                }
                else if (j == firstPol.unknown.Count())
                {
                    firstPol.unknown.Add(secondPol.unknown[i]);
                    firstPol.rSet.Add(secondPol.rSet[j]);
                }
            }
            return firstPol;
        }
    }
}
