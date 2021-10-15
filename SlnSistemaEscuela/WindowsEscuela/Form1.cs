using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaEscuela.Models;

namespace WindowsEscuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno("Carlos", "Ortega", 41565444, Convert.ToDateTime("29/04/2000"), 44);

            MessageBox.Show(" Nombre del Alumno: " + alumno.Nombre + "\n Apellido del Alumno: " + alumno.Apellido + "\n DNI del Alumno: " + alumno.DNI + "\n Fecha de Nacimiento del Alumno: " + alumno.FechaNacimiento.ToShortDateString() + "\n Nro de legajo del alumno:" + alumno.NroLegajo);

        }

        private void btnCrearProfesor_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor("Elena", "Genova", 25872097, Convert.ToDateTime("07/08/1977"), "Profesora de Historia");

            MessageBox.Show(" Nombre del Profesor: " + profesor.Nombre + "\n Apellido del Profesor: " + profesor.Apellido + "\n DNI del Profesor: " + profesor.DNI + "\n Fecha de Nacimiento del Profesor: " + profesor.FechaNacimiento.ToShortDateString() + "\n Titulo del profesor:" + profesor.Titulo);
        }
    }
}
