using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono
{
    class Program
    {
        static void Main(string[] args)
        {
            loop:
            try
            {
                Console.Write("1_BET:\t\t\t");
                double bet1 = Double.Parse(Console.ReadLine());
                Console.Write("1_COEFFICIENT:\t\t");
                double coefficient1 = Double.Parse(Console.ReadLine());
                double win1 = bet1 * coefficient1;
                Console.Write("2_COEFFICIENT:\t\t");
                double coefficient2 = Double.Parse(Console.ReadLine());
                double bet2 = (win1 / coefficient2);
                
                Console.WriteLine("2_BET:\t\t\t{0} UAH", bet2);
                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("WIN_1:\t\t\t{0} UAH", (bet1*coefficient1));
                Console.WriteLine("WIN_2:\t\t\t{0} UAH", (bet2 * coefficient2));
                
                Console.WriteLine("TOTAL BET:\t\t{0} UAH", bet2 + bet1);
                double clearwin = (win1 - (bet2 + bet1));
                Console.WriteLine("REAL WIN_1_2:\t\t{0} UAH = {1} %", clearwin, (clearwin * 100 / (bet2 + bet1)));

                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("REAL WIN_1_2:\t\t2_COEFFICIENT:");
                Console.ReadKey();
                double[] arr = new double[60];
                double coef = 1.0d;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = coef; 
                    coef += 0.05d;
                    Console.WriteLine("{3}\t{0}", coef, (win1 / coef), (bet1 + (win1 / coef)), win1 - (bet1 + (win1 / coef)));
                }
                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("1_BET:\t\t\t{0} UAH", bet1);
                Console.WriteLine("1_COEFFICIENT:\t\t{0}",coefficient1);
                Console.Write("2_COEFFICIENT_MIN+2:\t");
                double coefficient2min = Double.Parse(Console.ReadLine());
                double bet2max = (bet2 + clearwin/2);

                Console.WriteLine("2_BET_MAX:\t\t{0} UAH", bet2max);
                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("WIN_1:\t\t\t{0} UAH", (bet1 * coefficient1));
                Console.WriteLine("WIN_2:\t\t\t{0} UAH", coefficient2min*bet2max);
                Console.WriteLine("TOTAL BET:\t\t{0} UAH", bet2max + bet1);

                double win1case = (((win1 - bet2max - bet1)));
                Console.WriteLine("REAL WIN_1:\t\t{0} UAH = {1} %", win1case, ((win1case * 100) / (bet2max + bet1)));
                double win2case = (bet2max * coefficient2min) - (bet2max + bet1);
                Console.WriteLine("REAL WIN_2:\t\t{0} UAH = {1} %", win2case, ((win2case * 100)/(bet2max + bet1)));


                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("FINISH");
                Console.WriteLine();
                goto loop;
            }
            catch
            {
                goto loop;
            }

            
        }
    }
}