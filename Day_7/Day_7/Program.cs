using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            ReizTabula();
            /*Console.WriteLine("Ievadiet skaitli : ");
            string ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt16(ievade);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "*" + skaitlis + "=" + i * skaitlis);
            }
            */
            Console.ReadLine();
        }
        static void ReizTabula()
        {
            Console.WriteLine("Ievadiet skaitli : ");
            string ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt16(ievade);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "*" + skaitlis + "=" + i * skaitlis);
            }
        }



    }
}
