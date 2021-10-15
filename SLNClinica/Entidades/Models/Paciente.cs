using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Paciente
    {
        #region Propiedades Autoimplementadas
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int NroHistoriaClinica { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public int  Telefono { get; set; }
        #endregion

        #region Constructor
        public Paciente(string apellido,string nombre,int nroHistoriaClinica,string domicilio,string email,int telefono) 
        {
            Apellido = apellido;
            Nombre = nombre;
            NroHistoriaClinica = nroHistoriaClinica;
            Domicilio = domicilio;
            Email = email;
            Telefono = telefono;
        }
        #endregion-
    }
}
