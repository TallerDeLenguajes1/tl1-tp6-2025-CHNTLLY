// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);








//TP6 - EJERCICIO 1 - Altamirano Santiago Joaquin
string numeroS;
int numeroI;
bool resultado;

do
{
    Console.WriteLine("Ingrese un numero entero");
    numeroS = Console.ReadLine();
    resultado = int.TryParse(numeroS, out numeroI);
} while (!resultado);

//Console.WriteLine(resultado);

if (numeroI > 0)
{
    while (numeroI != 0)
    {
        Console.Write(numeroI % 10);
        numeroI = numeroI / 10;
    }
}
else
{
    Console.WriteLine();
}



//TP6 - EJERCICIO 2 - Altamirano Santiago Joaquin
string opcionS;
int opcionI;
bool opcionB;
float operando1=0, operando2=0;
string operando1S, operando2S;
bool operando1B, operando2B;

Console.WriteLine("\nOpcion 0: Salir del programa");
Console.WriteLine("Opcion 1: Sumar");
Console.WriteLine("Opcion 2: Restar");
Console.WriteLine("Opcion 3: Multiplicar");
Console.WriteLine("Opcion 4: Dividir");
do
{
    do
    {
        Console.WriteLine("Ingrese una opcion para continuar (0 para salir): ");
        opcionS = Console.ReadLine();
        opcionB = int.TryParse(opcionS, out opcionI);
        if (!opcionB)
        {
            Console.WriteLine("opcion invalida");
        }
    } while (!opcionB || opcionI<0 ||opcionI>4);

    if (opcionI != 0)
    { 
        Console.WriteLine("Ingrese 2 numeros para operar");
        do
        {
            Console.WriteLine("primer operando: ");
            operando1S = Console.ReadLine();
            operando1B = float.TryParse(operando1S, out operando1);
            if (!operando1B)
            {
                Console.WriteLine("numero invalido");
            }
        } while (!operando1B);

        do
        {
            Console.WriteLine("segundo operando: ");
            operando2S = Console.ReadLine();
            operando2B = float.TryParse(operando2S, out operando2);
            if (!operando2B)
            {
                Console.WriteLine("numero invalido");
            }
        } while (!operando1B);
    }
    switch (opcionI)
    {
        case 1:
            Sumar(operando1, operando2);
            break;
        case 2:
            Restar(operando1, operando2);
            break;
        case 3:
            Multiplicar(operando1, operando2);
            break;
        case 4:
            if (operando2 != 0)
            {
                Dividir(operando1, operando2);
            }
            else
            {
                Console.WriteLine("El segundo operando no puede ser 0!!!");
            }
            break;
        default:
            break;
    }
} while (opcionI!=0);




void Sumar(float num1, float num2)
{
    float retorno;
    retorno = num1 + num2;
    Console.WriteLine($"La suma de {num1} + {num2} es {retorno}");
}

void Restar(float num1, float num2)
{
    float retorno;
    retorno = num1 - num2;
    Console.WriteLine($"La resta de {num1} - {num2} es {retorno}");
}

void Multiplicar(float num1, float num2)
{
    float retorno;
    retorno = num1 * num2;
    Console.WriteLine($"El producto de {num1} * {num2} es {retorno}");
}

void Dividir(float num1, float num2)
{
    float retorno;
    retorno = num1 / num2;
    Console.WriteLine($"La division de {num1} / {num2} es {retorno}");
}