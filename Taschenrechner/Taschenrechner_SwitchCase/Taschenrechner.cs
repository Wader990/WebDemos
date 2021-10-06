using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_SwitchCase
{
   public class Taschenrechner
    {
        public double X;
        public double Y;
        public double? Ergebnis; // Ergebnis kann Nullable sein
        public string Message = "Falscher Operator";

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
