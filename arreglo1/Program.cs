//Leer 5 edades y mostrar la edad promedio

int[] edades = new int[5];
int suma = 0;
double promedio = 0;

for(int i = 0; i < edades.Length; i++)
{
    try
    {
        Console.WriteLine("Dime la edad " + (i + 1) + ":");
        edades[i] = int.Parse(Console.ReadLine());
    }
    catch(FormatException)
    {
        Console.WriteLine("Error: Ingresa un número válido.");
        i--; // Para volver a pedir la misma posición
    }
}
 
foreach(int edad in edades)
{
    suma += edad;
}
promedio = (double)suma / edades.Length;

Console.WriteLine("La edad promedio es: " + promedio);