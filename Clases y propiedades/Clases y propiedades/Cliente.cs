using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_propiedades
{
    public class Cliente
    {
        //Datos:
        public int Id;
        public string Name;

        private int _Numero;

        //los datos públicos se encapsulan, con funciones:
        public int GetNumero()
        {
            ///
            return _Numero;
        }
        public void SetNumero(int value)
        {
            //
            _Numero = value;
        }


        private int _AnioNac;

        //los datos públicos se encapsulan, con las funciones llamadas "setter" y "getter":
        public int AnioNac
        {
            get
            {
                ///
                return _AnioNac;
            }
            set
            {
                //
                _AnioNac = value;
            }
        }

        //de forma reducida:
        public int AnioNacimiento { get; set; }



    }
}


