using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taschenrechner_Web.Models;
using Taschenrechner_SwitchCase;

namespace Taschenrechner_Web.Controllers
{
    public class CalculaterController : Controller
    {
        // GET: Calculater
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Result(CalculaterViewModel aufgabe)
        {
            ResultViewModel ergebnis = new ResultViewModel();
            ergebnis.Input1= aufgabe.Input1;
            ergebnis.Input2 = aufgabe.Input2;
            ergebnis.Operator = aufgabe.Operator;
            Taschenrechner rechner = new Taschenrechner();
            switch (aufgabe.Operator)
            {
                case "+":
                    ergebnis.Result = rechner.Addieren(Convert.ToDouble(aufgabe.Input1), Convert.ToDouble(aufgabe.Input2));                    
                    break;
                case "-":
                    ergebnis.Result = rechner.Subtrahieren(Convert.ToDouble(aufgabe.Input1), Convert.ToDouble(aufgabe.Input2));
                    break;
                case "*":
                    ergebnis.Result = rechner.Multiplizieren(Convert.ToDouble(aufgabe.Input1), Convert.ToDouble(aufgabe.Input2));
                    break;
                case "/":
                    ergebnis.Result = rechner.Dividieren(Convert.ToDouble(aufgabe.Input1), Convert.ToDouble(aufgabe.Input2));
                    break;
                case "%":
                    ergebnis.Result = rechner.Modulo(Convert.ToDouble(aufgabe.Input1), Convert.ToDouble(aufgabe.Input2));
                    break;
            }          
            

            return View(ergebnis);
        }

        public ActionResult JavaScript()
        {
            return View();
        }




    }
}