using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Clinica
    {
        #region Propiedades Autoimplementadas
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        #endregion

        #region Constructores
        public Clinica() {}
        #endregion
    }
}
