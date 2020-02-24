using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViajesTuristicos.Models;

namespace ViajesTuristicos.Controllers
{
    public class HelperController : Controller
    {
        // GET: Helper
        public ActionResult Formulario()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Destino(Cliente cliente)
        {
            if(cliente.Destino == Dest.Playa)
            {
                cliente.pic = "/img/playa.jpg";
            }
            if (cliente.Destino == Dest.Montaña)
            {
                cliente.pic = "/img/montana.jpg";
            }
            if (cliente.Destino == Dest.Europa)
            {
                cliente.pic = "/img/europa.jpg";
            }
            if (cliente.Destino == Dest.USA)
            {
                cliente.pic = "/img/usa.jpg";
            }
            return View(cliente);
        }
    }
}