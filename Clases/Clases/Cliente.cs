using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente
    {
        //Datos:
        public int Id;
        public string Name;
        public int AnioNac;
        private int Numero;

        //funcionalidades
        public int CalcularEdad()
        {
            return AnioNac - 2023;
        }


    }
}
