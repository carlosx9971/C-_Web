// See https://aka.ms/new-console-template for more information

int numero;
short numPequeno;
string nombre;

numero = 10;
numPequeno=12;
nombre = "Carlos caraballo";

//OK
numero = numPequeno;

//casting
numPequeno =(short) numero;

//Convert
numPequeno = Convert.ToInt16(numero);
numero = Convert.ToInt32(numPequeno);

//Convert string a algún tipo y vis
nombre = "1345";
numero = Convert.ToInt32(nombre) ;

//de num a alfa
nombre = Convert.ToString(numero);
nombre = numero.ToString();

//Convert string a algún con Parse
nombre = "1345";
numero = Int32.Parse(nombre);
numPequeno = short.Parse(nombre);


int anioActual = 2023;
string valor;
int edad;

Console.WriteLine("Digite su anio de nacimiento:");
valor = Console.ReadLine();

//ERROR
//edad = anioActual - valor;

edad = anioActual - int.Parse(valor);

Console.WriteLine("La edad es {0} ",edad);

