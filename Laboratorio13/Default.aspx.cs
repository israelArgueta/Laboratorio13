using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio13
{
    public partial class _Default : Page
    {
        static List<estudiante> alum = new List<estudiante>();
        static List<Maestro> profe = new List<Maestro>();
        static List<Adminitracion> admin = new List<Adminitracion>();
        static List<Labores> labo = new List<Labores>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void sele_Click(object sender, EventArgs e)
        {
            
                if (ra.Checked)
                {
                    lo.Text = " ";
                    lo.Text = "Estudiantes:";
                    ca.Text = "";
                    ca.Text = "Carné:";
                    lo.Visible = true;
                    ca.Visible = true;
                    va.Visible = true;
                }
                else if (ra2.Checked)
                {
                    lo.Text = "";
                    lo.Text = "Profesores:";
                    ca.Text = " ";
                    ca.Text = "Id:";
                    lo.Visible = true;
                    ca.Visible = true;
                    va.Visible = true;
                    la.Visible = true;
                    mos.Visible = true;
                }
                else if (ra3.Checked)
                {
                    lo.Text = "";
                    lo.Text = "Personal Administrativo:";
                    ca.Text = "";
                    ca.Text = "IGGS:";
                    la.Text = "";
                    la.Text = "Profesión:";
                    lo.Visible = true;
                    ca.Visible = true;
                    va.Visible = true;
                    la.Visible = true;
                    labor.Visible = true;
                    final.Visible = true;
                    mos.Visible = true;
                    inicio.Visible = true;
                    laborfinal.Visible = true;
                }

            }
        
           



        

        protected void Agre_Click(object sender, EventArgs e)
        {
            if (ra.Checked)
            {
                estudiante estud = new estudiante();
                estud.Nombre = nom.Text;
                estud.Apellido = ape.Text;
                estud.Direccion = direc.Text;
                estud.Fechanac = fecha.SelectedDate;
                estud.edad();
                estud.Carnet = va.Text;

                alum.Add(estud);


                nom.Text = "";
                ape.Text = "";
                direc.Text = "";
                va.Text = "";
            }
            else if (ra2.Checked)
            {
                Maestro pro = new Maestro();
                pro.Nombre = nom.Text;
                pro.Apellido = ape.Text;
                pro.Direccion = direc.Text;
                pro.Fechanac = fecha.SelectedDate;
                pro.edad();
                pro.Id = va.Text;
                pro.Titulo = mos.Text;

                profe.Add(pro);


                nom.Text = "";
                ape.Text = "";
                direc.Text = "";
                va.Text = "";
                mos.Text = "";
            }
            else if (ra3.Checked)
            {
                Adminitracion ad = new Adminitracion();
                ad.Nombre = nom.Text;
                ad.Apellido = ape.Text;
                ad.Direccion = direc.Text;
                ad.Fechanac = fecha.SelectedDate;
                ad.edad();
                ad.Iggs = va.Text;
                ad.Profesion = mos.Text;
                ad.Fechainicial = inicio.SelectedDate;
                ad.Fechafinal = laborfinal.SelectedDate;

                admin.Add(ad);


                nom.Text = "";
                ape.Text = "";
                direc.Text = "";
                va.Text = "";
                mos.Text = "";
            }
            Labores lab = new Labores();
            lab.Estudiantes = alum.ToList();
            lab.Profesores = profe.ToList();
            lab.Administrativo = admin.ToList();
            labo.Add(lab);

            GuardarJsonA();

            labo.Clear();
            /*estudiante.Clear();
            profe.Clear();
            admins.Clear();*/

            lo.Visible = false;
            ca.Visible = false;
            va.Visible = false;
            la.Visible = false;
            labor.Visible = false;
            final.Visible = false;
            mos.Visible = false;
            inicio.Visible = false;
            laborfinal.Visible = false;

        }
        private void GuardarJsonA()
        {
            string json = JsonConvert.SerializeObject(labo);
            string archivo = Server.MapPath("Educador.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void ra_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}