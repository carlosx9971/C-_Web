using System.Collections;
using System.ComponentModel;

namespace Arreglos_y_listas
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var lista = new List<Cliente>();

            while (true)
            {
                PedirCliente(lista);
                Console.Write("Desear continuar (S/N) ");

                var s = Console.ReadLine();
                if (string.IsNullOrEmpty(s) || s.ToUpper() != "S") break;
            }

            Console.WriteLine($" ID        NOMBRE  ");

            foreach ( var c in lista)
            {
                Console.WriteLine($" {c.Id}     {c.Nombre} ");
            }


            Console.WriteLine("Programa terminado!!");
        }

        static void PedirCliente(List<Cliente> lista)
        {
            Cliente c = new Cliente();
            c.Id = lista.Count + 1;

            Console.Clear();
            Console.WriteLine("Digite el nombre del cliente: ");
            c.Nombre = Console.ReadLine();

            Console.WriteLine("Indique la cantidad de indentificaciones: ");
            var ni = int.Parse(Console.ReadLine());

            c.Identificaciones = new string[ni];
            for (var i = 0; i < ni; i++)
            {
                Console.WriteLine($"Indique la indentificación ({i + 1}): ");
                c.Identificaciones[i] = Console.ReadLine();
            }

            lista.Add(c);


        }
    }

}