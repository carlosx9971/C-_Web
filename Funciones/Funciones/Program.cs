namespace Funciones
{
    internal class Program
    {

        static void HacerAlgunaCosa()
        {

        }

        static int Sumar( int a, int b)
        {
            return a + b;
        }

        static void Verificar(int i)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"El valor {i} es num par");
            }
        }
       

        static void Main(string[] args)
        {

            HacerAlgunaCosa();

            var c = Sumar(3, 4);
            Console.WriteLine($"El resultado es {c}");

            int Restar(int a, int b)
            {
                return a - b;
            }

            var d = Restar(4, 2);


            for (var i = 0; i < 10; i++)
            {
                /*
                if (i % 2 == 0)
                {
                    Console.WriteLine($"El valor {i} es num par");
                }
                */
                Verificar(i);

            }

            for (var x = 0; x < 10; x++)
            {
                /*
                if (x % 2 == 0)
                {
                    Console.WriteLine($"El valor {x} es num par");
                }
                */
                Verificar(x);

            }


        }



    }
}