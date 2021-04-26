using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio13
{
    public class personas
    {
        string nombre;
        string apellido;
        string direccion;
        DateTime fechanac;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Fechanac { get => fechanac; set => fechanac = value; }
        public int edad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechanac.Year;
            if (fechanac.Month < fechaActual.Month)
            {
                edad--;
            }
            return edad;
        }
    }
    
}