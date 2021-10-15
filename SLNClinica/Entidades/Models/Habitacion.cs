using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Habitacion
    {
        #region Propiedades Autoimplementadas
        public int ID { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        #endregion

        #region Constructores
        public Habitacion() { }
        #endregion
    }
}
