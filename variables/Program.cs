// See https://aka.ms/new-console-template for more information


int numero;
short numPequeno;
double monto;
int numero2;
string nombre;

numero = 10;
numPequeno=12;
monto = 123.45;

numero2 =  numero; //OK

numPequeno=2;
numero = numPequeno;

//No es posible, int a short
//numPequeno = numero; //ERROR


nombre = "Carlos caraballo";

var otroNumero = 10d;
var otroNombre = "Carlos";


//Console.WriteLine(" El valor de numero es {0} y el nombre es {1} ",numero,nombre);
Console.WriteLine($" El valor de numero es {numero} y el nombre es {nombre}");
