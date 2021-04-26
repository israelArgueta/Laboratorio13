using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio13
{
    public class estudiante : personas
    {
        string carnet;

        public string Carnet { get => carnet; set => carnet = value; }
    }
    public class Maestro : personas
    {
        string id;
            string titulo;

        public string Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
    }

    public class Adminitracion : personas
    {
        string iggs;
        string profesion;
        DateTime fechainicial;
        DateTime fechafinal;

        public string Iggs { get => iggs; set => iggs = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public DateTime Fechainicial { get => fechainicial; set => fechainicial = value; }
        public DateTime Fechafinal { get => fechafinal; set => fechafinal = value; }
    }
    public class Labores
    {
        //string laboracion;
        List<estudiante> estudiantes = new List<estudiante>();
        List<Maestro> profesores = new List<Maestro>();
        List<Adminitracion> administrativo = new List<Adminitracion>();

        public List<estudiante> Estudiantes { get => estudiantes; set => estudiantes = value; }
        public List<Maestro> Profesores { get => profesores; set => profesores = value; }
        public List<Adminitracion> Administrativo { get => administrativo; set => administrativo = value; }
    }
}