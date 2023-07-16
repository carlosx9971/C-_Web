namespace Clases_y_propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cliente c = new Cliente();

            c.SetNumero(20);  //guarda el valor
            var x = c.GetNumero();  //lo toma

            c.AnioNac = 10;  //ejecuta el set
            var a = c.AnioNac; //ejecuta el get

            
            Console.WriteLine("Hello, World!");
            
        }
    }
}