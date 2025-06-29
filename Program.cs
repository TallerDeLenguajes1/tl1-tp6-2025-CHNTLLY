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

//TP6 - EJERCICIO 3 - Altamirano Santiago Joaquin
string num3S;
float num3f;
bool num3B;

do
{
    Console.WriteLine("\nIngrese un numero para operar");
    num3S = Console.ReadLine();
    num3B = float.TryParse(num3S, out num3f);
} while (!num3B);

// ● El valor absoluto de un número  
// ● El cuadrado 
// ● La raíz cuadrada  
// ● El seno 
// ● El Coseno  
// ● La parte entera de un tipo float.  

Console.WriteLine($"El valor absoluto del numero es:{float.Abs(num3f)}");
Console.WriteLine($"El cuadrado del numero es:{System.Math.Pow(num3f, 2)}");
if (num3f >= 0)
{
    Console.WriteLine($"La raiz cuadrada del numero es:{System.Math.Sqrt(num3f)}");
}
else
{
    Console.WriteLine("El numero no admite Raiz Cuadrada");
}
Console.WriteLine($"El seno del numero es:{System.Math.Sin(num3f)}");
Console.WriteLine($"El coseno del numero es:{System.Math.Cos(num3f)}");
if (num3f >= 0)
{
    Console.WriteLine($"La parte entera del numero es:{System.Math.Floor(num3f)}");
}
else
{
    Console.WriteLine($"La parte entera del numero es:{double.Abs(System.Math.Ceiling(num3f))}");
}


string operando3aS, operando3bS;
float operando3af, operando3bf;
bool operando3aB, operando3bB;

do
{
    Console.WriteLine("Ingrese dos numeros para operar");
    Console.WriteLine("Primer operando:");
    operando3aS = Console.ReadLine();
    Console.WriteLine("Segundo operando:");
    operando3bS = Console.ReadLine();
    operando3aB = float.TryParse(operando3aS, out operando3af);
    operando3bB = float.TryParse(operando3bS, out operando3bf);
} while (!operando3aB || !operando3bB);

Console.WriteLine($"El maximo es {System.Math.Max(operando3af, operando3bf)}");
Console.WriteLine($"El minimo es {System.Math.Min(operando3af, operando3bf)}");


