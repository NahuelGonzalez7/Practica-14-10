using LibreriaFiguras.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFiguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarSuperficieTriangulo_Click(object sender, EventArgs e)
        {
            decimal _base = Convert.ToDecimal(txtBase.Text);
            decimal altura = Convert.ToDecimal(txtAltura.Text);
            Triangulo triangulo = new Triangulo(_base,altura);
            decimal superficie = triangulo.superficieTriangulo(_base,altura);
            MessageBox.Show(Convert.ToString(superficie));
        }

        private void btnSuperficieRectangulo_Click(object sender, EventArgs e)
        {
            decimal _base = Convert.ToDecimal(txtBaseRectangulo.Text);
            decimal altura = Convert.ToDecimal(txtAlturaRectangulo.Text);
            Rectangulo rectangulo = new Rectangulo(_base, altura);
            decimal superficie = rectangulo.superficieRectangulo(_base, altura);
            MessageBox.Show(Convert.ToString(superficie));
        }

        private void btnSuperficieCirculo_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(txtRadioCirculo.Text);
            Circulo circulo = new Circulo(radio);
            double superficie = circulo.superficieCirculo(radio);
            MessageBox.Show(Convert.ToString(superficie));
        }
    }
}
