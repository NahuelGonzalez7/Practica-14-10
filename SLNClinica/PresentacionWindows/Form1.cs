using Entidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearClinica_Click(object sender, EventArgs e)
        {
            // Instanciacion

            Clinica clinica = new Clinica();

            // Asignacion de datos manualmente
            clinica.ID = 1;
            clinica.Nombre = "Clinica Colon";
            clinica.Domicilio = "Av. Colón 3629 ";
            clinica.Email = "clinicacolon@gmail.com";
            clinica.Telefono = 4992656;

            //Muestra de datos
            MessageBox.Show("\n ID: " + clinica.ID + "\n Nombre Clinica: " + clinica.Domicilio + "\n Email Clinica: " + clinica.Email + "\n Telefono clinica: " + clinica.Telefono);
        }

        private void btnCrearHabitacion_Click(object sender, EventArgs e)
        {
            Habitacion habitacion = new Habitacion();

            habitacion.ID = 1;
            habitacion.Numero = 0912;
            habitacion.Estado = "Libre";

            MessageBox.Show("\n ID: " + habitacion.ID + "\n Numero Habitacion: " + habitacion.Numero + "\n Estado Habitacion: " + habitacion.Estado);
        }
    }
}
