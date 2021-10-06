using System;

namespace Taschenrechner_SwitchCase
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

            switch (op)
            {
                case "+":
                    Aktion.Ergebnis = Aktion.Addieren(Aktion.X, Aktion.Y);
                    break;
                case "-":
                    Aktion.Ergebnis = Aktion.Aubtrahieren(Aktion.X, Aktion.Y);
                    break;
                case "*":
                    Aktion.Ergebnis = Aktion.Multiplizieren(Aktion.X, Aktion.Y);
                    break;
                case "/":
                    if (Aktion.Y != 0)
                    {
                        Aktion.Ergebnis = Aktion.Dividieren(Aktion.X, Aktion.Y);
                    }
                    else
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Das Teilen durch Null ist nicht möglich");
                    }
                    break;

                    
            }
            if (Aktion.Ergebnis.HasValue)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(Aktion.X + " " + op + " " + Aktion.Y + " = " + Aktion.Ergebnis);
            }
        }
    }
}
