namespace Demo_Ciclos_y_Cond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioActual = 2023;
            int edad;
            int anioNac;
            string valor;

            while (true)
            {
                Console.WriteLine("Digita tu anio de nac ");
                valor = Console.ReadLine();
                anioNac = int.Parse(valor);
                edad = anioActual - anioNac;
                Console.WriteLine($"La edad es {edad}");

                Console.WriteLine("Desea continuar s/n");
                valor = Console.ReadLine();
                if (valor == "n") break;

                Console.Clear();

            }
        }
    }
}