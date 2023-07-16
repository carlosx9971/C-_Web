using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases___Herencia_e_Interfaces
{
    public class Calculadora : ICalculadora
    {
        //Debo implementar todos los elementos de la interfaz

        public int ValorMaximo { get; set; }

        public void Restar(int a, int b)
        {
        }

        public void Sumar(int a, int b)
        {
        }
    }
}
