using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViajesTuristicos.Models
{
    public class Cliente
    {

        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Dest Destino { get; set; }
        public string pic { get; set; }
    }

    public enum Dest
    {
        Playa,Montaña,USA,Europa
    }
}