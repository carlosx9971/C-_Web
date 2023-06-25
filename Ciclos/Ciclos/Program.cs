namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* For
             
            for( inicio; condicion; incremento ){
                
                //break : para salir del ciclo
                //continue: saltar a una próxima interación
            }

            */
            /* While
             
             While (condicion)
             {
                //break : para salir del ciclo
                //continue: saltar a una próxima interación
             }
            */

            int n = 1;

            while ( n <= 10 )
            {
                Console.WriteLine(n);
                n = n + 1;
            }

            //genera el mismo resultado
            n = 1;
            while (true)
            {
                if (n > 10) break;

                Console.WriteLine(n);
                n = n + 1;

            }

            //ahora con for
            for(var i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            } 



        }
    }
}