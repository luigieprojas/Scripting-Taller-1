using System;

class Program
{
    static void Main()
    {
        float numero;
        float suma = 0;
        int contador = 0;
        string opcion = "S";

        while (opcion.ToUpper() == "S")
        {
            Console.Write("Ingrese un número: ");
            numero = float.Parse(Console.ReadLine());

            suma += numero;
            contador++;

            Console.Write("\n¿Desea continuar?\nS = Seguir\nT = Terminar\nOpción: ");
            opcion = Console.ReadLine();
            Console.WriteLine();
        }

        if (contador > 0)
        {
            float promedio = suma / contador;
            Console.WriteLine("El promedio de los números ingresados es: " + promedio);
        }
        else
        {
            Console.WriteLine("No se ingresaron números.");
        }

        Console.ReadKey();
    }
}
