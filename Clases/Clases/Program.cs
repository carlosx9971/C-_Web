namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //definir la variable
            Cliente oCliente;

            //Data error, no he creado un objeto primaro
            //oCliente.Name = "carlos caraballo";

            //crear el objeto
            oCliente = new Cliente(); //constructor

            oCliente.Name = "Carlos caraballo";
             

            //Console.WriteLine($" El nombre del cliente es {oCliente.Name}");

            Procesar(oCliente);

            Persona persona =  new Persona(1970);

            //persona = new Persona(1970);
            Console.WriteLine($"Anio nac {persona.AnioNac}");

        }

        static void Procesar(Cliente cliente)
        {
            Console.WriteLine($" El nombre del cliente es {cliente.Name}");
        }
    }
}