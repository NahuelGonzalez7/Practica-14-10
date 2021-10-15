using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFiguras.Models
{
    public class Triangulo
    {

        #region Propiedades Autoimplementadas
        public decimal Base { get; set; }
        public decimal Altura { get; set; }

        #endregion

        #region Constructores
        public Triangulo() { }

        public Triangulo(decimal Base,decimal Altura) 
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        #endregion

        #region Metodos
        public decimal superficieTriangulo(decimal Base,decimal Altura)
        {
            decimal superficie;

            superficie = (Base * Altura) / 2;

            return superficie;
        }
        #endregion
    }
}
