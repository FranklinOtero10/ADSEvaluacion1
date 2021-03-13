using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADSEvaluacion1.Models;

namespace ADSEvaluacion1.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones/Operaciones_Aritmeticas
        public ActionResult Operaciones_Aritmeticas(int operar = 0, Double valor1 = 0, Double valor2= 0)
        {
            Operaciones oper = new Operaciones();

            switch (operar)
            {
                case 1:
                    oper.operaracion = "Suma";
                    oper.resultado = valor1+valor2;
                    break;
                case 2:
                    oper.operaracion = "Resta";
                    oper.resultado = valor1 - valor2;
                    break;
                case 3:
                    oper.operaracion = "Multiplicación";
                    oper.resultado = valor1 * valor2;
                    break;
                case 4:
                    oper.operaracion = "División";
                    oper.resultado = valor1 / valor2;
                    break;
                default:
                    oper.resultado = 0;
                    break;
            }

            return View(oper);
        }

        
    }
}