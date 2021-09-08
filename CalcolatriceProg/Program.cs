using Calcolatrice2;
using System;
using Week7.Calcolatrice.Core;

namespace CalcolatriceProg
{
    public class Program
    {
        private static Calcolatrice calcolatrice = new Calcolatrice();
        static void Main(string[] args)
        {
            bool continua = true;
            while (continua)
            {
                int scelta = Start();
                continua = AnalizzaScelta(scelta);
            }
        }

        public static int Start()
        {

            Console.WriteLine("Calcolatrice!");

            Console.WriteLine("Scegli l'operazione da Eseguire:");
            int scelta;
            Console.Write("Inserisci scelta: ");
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 4)
            {
                Console.Write("\nScelta errata. Inserisci scelta corretta: ");
            }
            return scelta;

        }
        private static bool AnalizzaScelta(int scelta)
        {
            switch (scelta)
            {
                case 1:
                    Somma();
                    break;
                case 2:
                    Sottrazione();
                    break;
                case 3:
                    Moltiplicazione();
                    break;
                case 4:
                    Divisione();
                    break;

                case 0:
                    return false;
            }
            return true;
        }


        private static void Somma()
        {
            Console.WriteLine("Immetti due valori");
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());

            Calcolatrice calcolatrice = new Calcolatrice();
            double risultato = calcolatrice.Somma(x, y);

            if (risultato == null)
            {
                Console.WriteLine("Calcolo impossibile");
            }
            else
            {
                Console.WriteLine($"Risultato:{risultato}");
            }

        }
        private static void Divisione()
        {
            {
                Console.WriteLine("Immetti due valori");
                Console.Write("x=");
                double x = double.Parse(Console.ReadLine());
                Console.Write("y=");
                double y = double.Parse(Console.ReadLine());

                Calcolatrice calcolatrice = new Calcolatrice();
                double risultato = calcolatrice.Div(x, y);

                if (risultato == null)
                {
                    Console.WriteLine("Calcolo impossibile");
                }
                else
                {
                    Console.WriteLine($"Risultato:{risultato}");
                }

            }
        }

        private static void Moltiplicazione()
        {
            {
                Console.WriteLine("Immetti due valori");
                Console.Write("x=");
                double x = double.Parse(Console.ReadLine());
                Console.Write("y=");
                double y = double.Parse(Console.ReadLine());

                Calcolatrice calcolatrice = new Calcolatrice();
                double risultato = calcolatrice.Moltiplicazione(x, y);

                if (risultato == null)
                {
                    Console.WriteLine("Calcolo impossibile");
                }
                else
                {
                    Console.WriteLine($"Risultato:{risultato}");
                }

            }
        }

        private static void Sottrazione()
        {
            Console.WriteLine("Immetti due valori");
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());

            Calcolatrice calcolatrice = new Calcolatrice();
            double risultato = calcolatrice.Sottrazione(x, y);

            if (risultato == null)
            {
                Console.WriteLine("Calcolo impossibile");
            }
            else
            {
                Console.WriteLine($"Risultato:{risultato}");
            }

        }
    }
}
    