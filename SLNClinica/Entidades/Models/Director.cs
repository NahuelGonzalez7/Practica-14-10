using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Director
    {
        #region Propiedades Autoimplementadas
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Especialidad { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Area { get; set; }
        #endregion

        #region Constructores
        public Director(string apellido,string nombre, string matricula,string especialidad, string domicilio, string email,int telefono,string area)
        {
            Apellido = apellido;
            Nombre = nombre;
            Matricula = matricula;
            Especialidad = especialidad;
            Domicilio = domicilio;
            Email = email;
            Telefono = telefono;
            Area = area;
       }
        #endregion
    }
}
