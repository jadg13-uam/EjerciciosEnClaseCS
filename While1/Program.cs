//leer un numero entero y mostrar el cuadrado de sus antecesores

using System;

int numero;

while (true)
{
    Console.Write("Ingrese un numero entero: ");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Por favor, ingrese un numero entero.");
        Console.ResetColor();
    }
}

Console.WriteLine("Mostrando el cuadrado de los antecesores de " + numero + ":");
int cont = 1;
while(cont < numero)
{
    Console.WriteLine("El cuadrado de " + cont + " es: " + Math.Pow(cont, 2));
    cont++;
}