using System;

namespace Aufgabe_Taschenrechner_26_08_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Taschenrechner Aktion = new Taschenrechner();
            Console.WriteLine("Bitte die erste Zahl eingeben");
            Aktion.X = Convert.ToDouble(Console.ReadLine());   //Erste Zahl in x speichern
            
            Console.WriteLine("Bitte die erste Zahl eingeben");
            Aktion.Y = Convert.ToDouble(Console.ReadLine());//zweite Zahl in y speichern

            Console.WriteLine("Bitte die Operator eingeben: nur (+) __ (-) __ (*) __ (/) sind zulässig");
            string op = Console.ReadLine();
            if (op == "+")
            {
                Aktion.Ergebnis = Aktion.Addieren(Aktion.X, Aktion.Y);                
            }
            else if (op == "-")
            {
                Aktion.Ergebnis = Aktion.Aubtrahieren(Aktion.X, Aktion.Y);                
            }
            else if (op == "*")
            {
                Aktion.Ergebnis = Aktion.Multiplizieren(Aktion.X, Aktion.Y);                
            }
            else if (op == "/")
            {
                if (Aktion.Y == 0)
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Das Teilen durch 0 ist nicht möglich");
                }
                else Aktion.Ergebnis = Aktion.Dividieren(Aktion.X, Aktion.Y);                
            }
            else { Console.WriteLine(Aktion.Message); }

                       
            if (Aktion.Ergebnis.HasValue)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(Aktion.X + " " + op + " " + Aktion.Y + " = " + Aktion.Ergebnis);
            }

        }
    }
}
