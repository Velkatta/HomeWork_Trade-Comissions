using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_bussinesComision
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var s = double.Parse(Console.ReadLine());

            var comission = -1.00;

            if (town == "Sofia")
            {
                if (0 <= s && s <= 500)
                {
                    comission = 0.05; //Console.WriteLine("{0:f2}" , s * 0.05);
                }
                else if (500 < s && s <= 1000)
                {
                    comission = 0.07; //Console.WriteLine("{0:f2}" , s * 0.07);
                }
                else if (1000 < s && s <= 10000)
                {
                    comission = 0.08; //Console.WriteLine("{0:f2}", s * 0.08);
                }
                else if (s > 10000)
                {
                    comission = 0.12; //Console.WriteLine("{0:f2}", s * 0.12);
                }
            }
            else if (town == "Varna")
            {
                if (0 <= s && s <= 500)
                {
                    comission = 0.045; //Console.WriteLine("{0:f2}", s * 0.045);
                }
                else if (500 < s && s <= 1000)
                {
                    comission = 0.075; //Console.WriteLine("{0:f2}", s * 0.075);
                }
                else if (1000 < s && s <= 10000)
                {
                    comission = 0.10; //Console.WriteLine("{0:f2}", s * 0.10);
                }
                else if (s > 10000)
                {
                    comission = 0.13; //Console.WriteLine("{0:f2}", s * 0.13);
                }
            }
            else if (town == "Plovdiv")
            {
                if (0 <= s && s <= 500)
                {
                    comission = 0.055; //Console.WriteLine("{0:f2}", s * 0.055);
                }
                else if (500 < s && s <= 1000)
                {
                    comission = 0.08; //Console.WriteLine("{0:f2}", s * 0.08);
                }
                else if (1000 < s && s <= 10000)
                {
                    comission = 0.12; //Console.WriteLine("{0:f2}", s * 0.12);
                }
                else if (s > 10000)
                {
                    comission = 0.145; //Console.WriteLine("{0:f2}", s * 0.145);
                }
            }
            if (comission >= 0)
            {
                Console.WriteLine("{0:f2}" , s * comission);
            }
            else
            {
                Console.WriteLine("error");
            }
            //Console.WriteLine("{0:f2}" , (s * comission));
        }
    }
}
