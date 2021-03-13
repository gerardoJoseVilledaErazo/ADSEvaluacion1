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
            Operaciones op = new Operaciones() { op1 =11, op2 = 3, suma = 0};
            op.suma = op.op1 + op.op2;
            op.resta = op.op1 - op.op2;
            op.mult = op.op1 * op.op2;
            op.div = op.op1 / op.op2;
            return View(op);
        }


        public ActionResult Suma()
        {
            Operaciones op = new Operaciones() { op1 = 11, op2 = 3, suma = 0 };
            op.suma = op.op1 + op.op2;

            return View(op);
        }

        public ActionResult Resta()
        {
            Operaciones op = new Operaciones() { op1 = 11, op2 = 3, resta = 0 };
            op.resta = op.op1 - op.op2;
            return View(op);
        }

        public ActionResult Multiplicacion()
        {
            Operaciones op = new Operaciones() { op1 = 11, op2 = 3, mult = 0 };
            op.mult = op.op1 * op.op2;
            return View(op);
        }

        public ActionResult Division()
        {
            Operaciones op = new Operaciones() { op1 = 11, op2 = 3, div = 0 };
            op.div = op.op1 / op.op2;
            return View(op);
        }
    }
}