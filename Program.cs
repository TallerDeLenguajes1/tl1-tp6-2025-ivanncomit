// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int a;
int b;

int numero;

string entrada;

a = 10;
b = a;

Console.WriteLine("valor de a:"+a);
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
    } else
    {
        Console.WriteLine("El numero es > 0, se invierte:");
    
        do
        {
            Console.Write(numero % 10);
            numero = numero / 10;
        } while (numero / 1 != 0);    
        }

}