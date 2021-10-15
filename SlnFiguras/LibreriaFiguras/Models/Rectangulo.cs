using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFiguras.Models
{
    public class Rectangulo
    {

        #region Constructores
        
        public Rectangulo(decimal _base,decimal altura) 
        {
            this._base = _base;
            Altura = altura;
        }

        #endregion

        #region propiedades autoimplementadas
        public decimal _base {get; set;}
        public decimal Altura { get; set; }

        #endregion

        #region metodos
        
        public decimal superficieRectangulo(decimal _base,decimal altura)
        {
            decimal superficie;

            superficie = _base * altura;

            return superficie;
        }

        #endregion

    }
}
