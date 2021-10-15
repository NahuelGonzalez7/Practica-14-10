using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFiguras.Models
{
    public class Circulo
    {
        #region Constructores
   
        public Circulo(double radio) 
        {
            Radio = radio;
        }
        
        #endregion

        #region Propiedades Autoimplementadas
        public double Radio { get; set; }
        #endregion

        #region Metodos

        public double superficieCirculo(double radio)
        {
            double area;

            area = Math.PI * Math.Pow(radio, 2);

            return area;
        }

        #endregion 
    }
}
