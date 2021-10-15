using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEscuela.Models
{
    public class Alumno
    {
        #region Propiedades Autoimplementadas
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NroLegajo { get; set; }
        #endregion

        #region Constructor
        public Alumno(string nombre, string apellido, decimal dni, DateTime fechaNacimiento, int nroLegajo)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            FechaNacimiento = fechaNacimiento;
            NroLegajo = NroLegajo;
        }
        #endregion
    }
}
