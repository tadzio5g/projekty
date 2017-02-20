using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwszy_program
{
    class Kwadrat
    {

        int iloscKropek = 5;

        ConsoleColor kolor;// = ConsoleColor.Green;

        public Kwadrat (int iloscKropek1, ConsoleColor kolor1)
        {
            iloscKropek = iloscKropek1;
            kolor = kolor1;
        }

        public void RysujKwadrat()
        {
            Console.ForegroundColor = kolor;
            //Console.Write("Wpisz ilość kropek: ");
            //iloscKropek = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=iloscKropek; i++)
            {
                for (int j = 1; j <= iloscKropek; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }            
        }        
    }
}
