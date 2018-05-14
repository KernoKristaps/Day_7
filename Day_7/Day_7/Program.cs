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



            Darbs2();

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            

            ReizTabula();
            Darbs();
            
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
                Console.WriteLine(i + "*" + skaitlis + "=" + i * skaitlis +"\n");
            }
        }
        static void Darbs()
        {
            string n = "";
            for (int i = 1; i < 4; i++) 
            {
                n = n + "*";
                Console.WriteLine(n);
                
            }

            Console.ReadLine();

        }
        static void Darbs2()
        {
            Console.WriteLine("Ievadiet skaitli : ");
            int Ver = 0;            
            string ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt16(ievade);

            
            for (int i = 1; i <= skaitlis; i++) 
            {
                int OldVer = Ver;
                Ver = Ver + i;
                Console.WriteLine(OldVer + "+" + i + "=" + Ver);
                
            }
            Console.ReadLine();
        }
           


    }
}
