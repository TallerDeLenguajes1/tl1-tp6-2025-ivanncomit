// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int a;
int b;

int numero, opcion=1;

string entrada;

a = 10;
b = a;

Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

do
{
    Console.WriteLine("Ingresa un numero entero: ");
    entrada = Console.ReadLine();
} while (!(int.TryParse(entrada, out numero)));

InvierteONo(numero);

void InvierteONo(int numero)
{
    if (numero < 0)
    {
        Console.WriteLine("El numero es < 0, no se invierte: " + numero);
    }
    else
    {
        Console.WriteLine("\nEl numero es > 0, se invierte:");

        do
        {
            Console.Write(numero % 10);
            numero = numero / 10;
        } while (numero / 1 != 0);
    }

}
/*

Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.

*/

// MENU

while (opcion > 0 && opcion < 5)
{
    Console.WriteLine("Que Operacion desea realizar?\n\n\nSumar - 1\nRestar - 2\nMultiplicar - 3\nDividir - 4\nSalir - c/o");
    entrada = Console.ReadLine();
    int.TryParse(entrada, out opcion);
    switch (opcion)
    {
        case 1: sumar();
            break;
        case 2: restar();
            break;
        case 3: Multiplicar();
            break;
        case 4: Dividir();
            break;            
    }
}



float sumar()
{
    string entrada;
    float numero1, numero2;
    do
    {
        Console.WriteLine("Ingresa el primer numero: ");
        entrada = Console.ReadLine();
    } while (!(float.TryParse(entrada, out numero1)));

    do
    {
        Console.WriteLine("Ingresa el segundo numero: ");
        entrada = Console.ReadLine();
    } while (!(float.TryParse(entrada, out numero2)));

    System.Console.WriteLine(numero1+numero2);
    return (numero1 + numero2);
}

float restar()
{
    string entrada;
    float numero1, numero2;
    do
    {
        Console.WriteLine("Ingresa el primer numero: ");
        entrada = Console.ReadLine();
    } while (!(float.TryParse(entrada, out numero1)));

    do
    {
        Console.WriteLine("Ingresa el segundo numero: ");
        entrada = Console.ReadLine();
    } while (!(float.TryParse(entrada, out numero2)));
    System.Console.WriteLine(numero1-numero2);
    return (numero1 - numero2);
}

float Multiplicar()
{
    string entrada;
    float numero1, numero2;
    do
    {
        Console.WriteLine("Ingresa el primer numero entero: ");
        entrada = Console.ReadLine();
    } while (!(float.TryParse(entrada, out numero1)));

    do
    {
        Console.WriteLine("Ingresa el segundo numero entero: ");
        entrada = Console.ReadLine();
    } while (!(float.TryParse(entrada, out numero2)));
    System.Console.WriteLine(numero1*numero2);
    return (numero1 * numero2);
}

float Dividir()
{
    string entrada;
    float numero1, numero2;
    do
    {
        Console.WriteLine("Ingresa el primer numero entero: ");
        entrada = Console.ReadLine();
    } while (!(float.TryParse(entrada, out numero1)));

    do
    {
        Console.WriteLine("Ingresa el segundo numero entero: ");
        entrada = Console.ReadLine();
    } while (!(float.TryParse(entrada, out numero2))&&numero2!=0);

    System.Console.WriteLine(numero1 / numero2);
    return (numero1 / numero2);
}