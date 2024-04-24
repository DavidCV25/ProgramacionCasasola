namespace Ejercicio_2;

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Error: Muchos argumentos");
            return;
        }
        string ficheroDeOrigen = args[0];
        string ficheroDeDestino = args[1];
        try
        {
            File.Copy(ficheroDeOrigen, ficheroDeDestino, true);
            Console.WriteLine($"El fichero ha sido copiado correctamente.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: No se pudo encontrar el fichero de origen.");
        }
    }
}
