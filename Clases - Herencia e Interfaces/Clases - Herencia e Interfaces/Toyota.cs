using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases___Herencia_e_Interfaces
{
    public class Toyota : Vehiculo
    {
        //Es obligatorio que implemente el método abstracto
        public override void Correr()
        {
            Console.WriteLine("Corriendo con un toyota");

        }
    }
}
