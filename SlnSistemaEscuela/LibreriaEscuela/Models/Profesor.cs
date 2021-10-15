using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEscuela.Models
{
    public class Profesor
    {
        #region Propiedades Autoimplementadas
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Titulo { get; set; }
        #endregion

        #region Constructores
        public Profesor(string nombre, string apellido, decimal dni, DateTime fechaNacimiento, string titulo)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            FechaNacimiento = fechaNacimiento;
            Titulo = titulo;
        }
        #endregion
    }
}
