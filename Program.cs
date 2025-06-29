// See https://aka.ms/new-console-template for more information
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
    Console.WriteLine(numeroI);
}