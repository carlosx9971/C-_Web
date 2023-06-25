namespace Comandos_de_Repeticion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;

            n = 10;

            /*
            if ( n > 10)
            {
                Console.WriteLine("El número es mayor de 10 ");
            }
            */

            /*
            if( n > 10)
            {
                Console.WriteLine("El número es mayor de 10 ");
            }
            else
            {
                Console.WriteLine("El número es menor o igual a 10 ");
            }
            */

            /*
            if (n == 10) Console.WriteLine(" El num es igual 10 ");

            if (n != 10)
            {
                Console.WriteLine(" El valor es dif de 10 ");
            }
            else if (n == 12)
            {
                Console.WriteLine(" El valor es 12 ");
            }
            else if (n == 13)
            {
                Console.WriteLine(" El valor es 13 ");
            }
            */



            /*
             switch (codicion)
             {
                case posible valor:
                    ejecuta alguna cosa
                    break
             }

            */
            n = 10;

            switch (n)
            {
                case 1:
                    Console.WriteLine("Es igual a 1");
                    break;
                case 2:
                    Console.WriteLine("es igual a 2");
                    break;
                default:
                    Console.WriteLine("no es igual 1 , ni es igual a 2");
                    break;
            }




            //el programa sique aquí
            Console.WriteLine("Programa terminado");

        }
    }
}