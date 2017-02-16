using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pierwszy_program
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////
            /*
            // Pierwszy program 
          
            Double x, y;
            Console.WriteLine("Witaj świecie");
            Console.WriteLine("Podaje stopnie farenheita");
            x = double.Parse(Console.ReadLine());
            y = 5d / 9 * (x - 32);
            Console.WriteLine(y);
            */

            //////////////////////////////////////////////////////////////////////////////////
            /*
            // Drugi program

            const int liczba_miesiecy=12;
            int liczba_samochodow;
            double srednia_liczba_samochodow;
            Console.WriteLine("podaj liczbe samochodow sprzedaną w ciągu roku");
            // liczba_samochodow = Convert.ToInt32(Console.ReadLine());
            liczba_samochodow = int.Parse(Console.ReadLine());
            srednia_liczba_samochodow = (double)liczba_samochodow / liczba_miesiecy;

            Console.WriteLine(srednia_liczba_samochodow);
            */
            //////////////////////////////////////////////////////////////////////////////////
            // Trzeci program
            /*
            double x,y;

            Console.WriteLine("Proszę podać wartość wiekszą od zera: ");
            x = double.Parse(Console.ReadLine());
            y = Math.PI * (Math.Sqrt(Math.Abs(Math.Sin(x)) * Math.Log(x, 2.0)));
            Console.WriteLine(y);
            */

            //////////////////////////////////////////////////////////////////////////////////
            // Czwarty program

            /*
            Console.WriteLine("suma=" + 5 + 5 + " iloczyn=" + 5 * 5);
            Console.WriteLine("Podaj imię: ");
            string tekst = Console.ReadLine();

            Console.WriteLine("cześć " + tekst);
            tekst = "cześć " + tekst;
            // Console.WriteLine(tekst);
            int dlugosc_slowa = tekst.Length;
            Console.WriteLine("Długość zdania jest rowna: " + dlugosc_slowa);
            */
            //////////////////////////////////////////////////////////////////////////////////

            // Piąty program
            
            //ddfd dfdfdfdfdf

            double wzrost;
            double waga;
            double wskaznikBMI;
            bool CzyWagaNorma;

            Console.WriteLine("Program obliczajacy Twój wskaźnik BMI");

            Console.WriteLine("Proszę podać wzrost [m]: ");
            wzrost = double.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać wagę [kg]: ");
            waga = double.Parse(Console.ReadLine());

            wskaznikBMI = waga / (wzrost * wzrost);

            CzyWagaNorma = (wskaznikBMI >= 18.5 && wskaznikBMI <= 25.00);

            Console.WriteLine("------------Podsumowanie------------");
            Console.WriteLine("Twoja waga wynosi: {0}kg, twój wzrost wynosi: {1}m", waga, wzrost);
            Console.WriteLine("Twój wskaźnik BMI wynosi {0,2:F2}", wskaznikBMI);

            if (CzyWagaNorma == true)
                {
                    Console.WriteLine("Twój wskaźnik BMI jest bardzo dobry :)");
                }
            else if (wskaznikBMI < 18.5)
                {
                    Console.WriteLine("Musisz więcej jeść!!!");
                }
            else if (wskaznikBMI > 25.00)
                {
                    Console.WriteLine("Musisz mniej jeść!!!");
                }

            // fdefdfdfdfdf

            //////////////////////////////////////////////////////////////////////////////////

            // Szósty program

            /*
            int kostka;
            int punkty;
            Random rand = new Random();  // generator liczb losowych - przypisanie do zmiennej "rand"
            kostka = rand.Next(1, 7);
            // punkty = (kostka == 6) ? kostka * 2 : kostka;
            if (kostka == 6)
            {
                punkty = kostka * 2;
                Console.WriteLine("wartość punktów wynosi: {0}", punkty);
            }
            else
            {
                Console.WriteLine("wartość punktów wynosi: {0}", kostka);
            }
            //Console.WriteLine("wartość punktów wynosi: {0}", punkty);
            */

            //////////////////////////////////////////////////////////////////////////////////

            // śiódmy program instrukcje switch i case
            /*
            Console.WriteLine("Proszę wpisać porę roku (bez polskich znakow): ");
            String PoraRoku = Console.ReadLine();

            switch (PoraRoku)
            {
                case "wiosna":
                    Console.WriteLine("Wpisałeś wiosna");
                    break;
                case "zima":
                    Console.WriteLine("Wpisaleś zima");
                    break;
                case "lato":
                    Console.WriteLine("Wpisałeś lato");
                    break;
                case "jesien":
                    Console.WriteLine("Wpisałeś jesień");
                    goto case "lato";
                    break;
                default:
                    Console.WriteLine("Nie ma takiej pory roku");
                    break;
            }
            */
            //////////////////////////////////////////////////////////////////////////////////
            // ósmy program - pętla for

            /*
            Console.WriteLine("prosze podać liczbę" );
            int liczba = int.Parse(Console.ReadLine());

            for (int i=1; i<=liczba; i++)
            {
                Console.WriteLine("\n");
                for (int j=1; j<=liczba; j++)
                {
                    Console.Write("{0,3} ", i * j);
                }
            }

            */

            //////////////////////////////////////////////////////////////////////////////////

            // 9 program - pętla while
            /*
            int liczbaPoczatkowa = 0, aktualnaliczba=0;

            Random rand = new Random();

            while (aktualnaliczba != 10)
            {
                
                aktualnaliczba = rand.Next(1, 11);
                
                Console.WriteLine("obecna wartość liczby: {0,4}", aktualnaliczba);
                liczbaPoczatkowa += aktualnaliczba;
                Console.WriteLine("aktualna suma jest równa: {0,4}", liczbaPoczatkowa);
            }

            */

            //////////////////////////////////////////////////////////////////////////////////

            // 10 program - pętla  do while
            /*
            string odpowiedz;

            do
            {
                Console.WriteLine("Aktualny czas to: {0}", DateTime.Now);
                Console.WriteLine("Czy pokazać czas jeszcze raz (t/n): ");
                odpowiedz = Console.ReadLine();

            } while (odpowiedz != "n");
            */
            Console.ReadKey();
                  

        }
    }
}


