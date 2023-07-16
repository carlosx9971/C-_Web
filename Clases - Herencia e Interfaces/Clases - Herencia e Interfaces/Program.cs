namespace Clases___Herencia_e_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona oPersona = new Persona();
            Cliente oCliente = new Cliente();

            oCliente.Name = "carlos caraballo";
            oCliente.Balance = 100;

            //no puedo crear un objeto de tipo vehiculo, es abstracto
            //Vehiculo v = new Vehiculo(); //da error
            //pero puedo:
            Honda honda = new Honda();
            Toyota toyota = new Toyota();

            //Si puedo:
            Vehiculo v = new Honda();
            //es correcto:
            //v = new Toyota();

            //Conseguir algo usando casting:
            string valor = ((Honda)v).AlgoHonda;

            //No puedo:
            //Honda h = new Toyota(); 


            Procesar(honda);
            Procesar(toyota);
        }

        static void Procesar( Vehiculo v)
        {
            if( v is Honda)
            {
                Console.WriteLine("Estoy trabajando con un honda");
            }
            v.Correr();
        }
    }
}