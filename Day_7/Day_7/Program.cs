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

            int izvele = 1;
            while(izvele !=0)
            {
                Console.WriteLine("\n" + "1- izvadit reizrekina tabula");
                Console.WriteLine("2- darbsNr1");
                Console.WriteLine("3- darbsNr2");
                Console.WriteLine("4- Faktorialais");
                Console.WriteLine("0- Iziet\n");

                string input = Console.ReadLine();
                izvele = Convert.ToInt16(input);

                switch (izvele)
                {
                    case 1:
                        ReizTabula();
                        break;
                    case 2:
                        Darbs();
                        break;
                    case 3:
                        Darbs2();
                        break;
                    case 0:
                        izvele = 0;
                        break;
                    default:
                        Console.WriteLine("Ievade nav pareiza \n");
                        break;
                }
            }
            Darbs2();

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            

            

            /*ReizTabula();
            Darbs();
            
            Console.WriteLine("Ievadiet skaitli : ");
            string ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt16(ievade);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "*" + skaitlis + "=" + i * skaitlis);
            }*/
            
            
            
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
                Console.WriteLine("\n"+ n);
                
            }

            

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
            
        }
           


    }
}
