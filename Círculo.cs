using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Círculo // criando classe circulo e definindo variavel raio
    {
        public double Raio { get; set; }
       

        public Círculo(double raio) //constrção da classe e criar o objeto circulo
        { 
            Raio = raio;           
        }

        public double CalcularArea() //metodo para calcular a area do circulo
        {
            return Math.PI * Math.Pow(Raio, 2); //Math.PI=PI e Math.Pow=Potencia
        } 
        public double CalcularPerimetro() //metodo para calcular o perimetro do circulo
        {
            return 2 * Math.PI * Raio; 
        }

    }
}
