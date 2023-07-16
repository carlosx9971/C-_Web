using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases___Herencia_e_Interfaces
{
    //la interface solo puede tener elementos propuestos:

    public interface ICalculadora
    {
        int ValorMaximo { get; set; }

        void Sumar(int a, int b);
        void Restar(int a, int b);
    }
}
