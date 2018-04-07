using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_7._4._2 {
    class Program {
        static void Main(string[] args) {

            int saldo = 0;
            bool bank = true;
            
            //      Menu
            Console.WriteLine("Välkommen till banken! Välj ett alternativ nedan:");
            Console.WriteLine("[I]sättning");
            Console.WriteLine("[U]ttag");
            Console.WriteLine("[S]aldo");
            Console.WriteLine("[A]vsluta");
            Console.WriteLine();

            while(bank == true) {

                string menuChoice = Console.ReadLine();

                switch(menuChoice) {
                    case "I":
                    case "i":
                        Console.Write("Önskad summa att sätta in: ");
                        int insattning = Convert.ToInt32(Console.ReadLine());
                        saldo=saldo+insattning;
                        Console.WriteLine("Ditt saldo är nu: {0}kr", saldo);
                        Console.WriteLine();
                        break;

                    case "U":
                    case "u":
                        Console.Write("Önskad summa att ta ut: ");
                        int uttag = Convert.ToInt32(Console.ReadLine());
                        saldo=saldo-uttag;
                         Console.WriteLine("Ditt saldo är nu: {0}kr", saldo);
                         Console.WriteLine();
                         break;

                    case "S":
                    case "s":
                        Console.WriteLine("Ditt saldo är: {0}kr", saldo);
                        Console.WriteLine();
                        break;

                    case "A":
                    case "a":
                        bank=false;
                        break;
                    /* I must use a bool to "control" the while-loop
                     since a bool can be true or false, I can end the
                     program by changeing my bool to false. */
                    
                    default:
                        Console.WriteLine("Var vänlig och välj ett alternativ i menyn.");
                        break;
                }
                
            }
            Console.WriteLine("Tack för att du använde tjänsten!");
            Console.ReadLine();
        }
    }
}
