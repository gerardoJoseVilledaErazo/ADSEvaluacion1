using ADSEvaluacion1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADSEvaluacion1.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones/Operaciones
        public ActionResult Operaciones()
        {
            Operaciones op = new Operaciones() { op1 = 11, op2 = 3, suma = 0};
            op.suma = op.op1 + op.op2;
            op.resta = op.op1 - op.op2;
            op.mult = op.op1 * op.op2;
            op.div = op.op1 / op.op2;
            /*
            String opc = "";
            switch (opc)
            {
                case "Suma": op.suma = op.op1 + op.op2; break;
                case "Resta": op.resta = op.op1 - op.op2; break;
                case "Multiplicacion": op.mult = op.op1 * op.op2; break;
                case "Division": op.div = op.op1 / op.op2; break;
            }*/
            return View(op);
        }
    }
}