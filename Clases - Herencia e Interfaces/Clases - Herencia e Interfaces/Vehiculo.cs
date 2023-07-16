using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases___Herencia_e_Interfaces
{
    public abstract class Vehiculo
    {
        public string Name { get; set; }


        //Es una método con su desarrollo:
        public virtual void Arrancar()
        {
            Console.WriteLine("Un carro arrancando...");
        }

        //Es un método propuesto, solo tiene la firma:
        public abstract void Correr();
         
    }
}
