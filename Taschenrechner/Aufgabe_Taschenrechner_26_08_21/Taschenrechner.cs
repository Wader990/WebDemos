using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Taschenrechner_26_08_21
{
   public class Taschenrechner
    {
       public double X;
       public double Y;
       public double? Ergebnis;
       public string Message= "Falscher Operator";

        public double Addieren(double a, double b)
        {
            return a + b;
        }

        public double Aubtrahieren(double a, double b)
        {
            return a - b;
        }

        public double Multiplizieren(double a, double b)
        {
            return a * b;
        }

        public double Dividieren(double a, double b)
        {
            return a / b;
        }

        
    }
}
