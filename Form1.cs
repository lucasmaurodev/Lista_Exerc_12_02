using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double.TryParse(txtRaio.Text, out double raio);
            Círculo circulo = new Círculo(raio);
            double area = circulo.CalcularArea();
            double perimetro = circulo.CalcularPerimetro();

            lblResult.Text = $"Área: {area.ToString("F2")}\nPerímetro: {perimetro.ToString("F2")}";
        }
    }
}
