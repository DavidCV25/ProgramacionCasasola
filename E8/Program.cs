namespace Ejercicio_8;

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {  
        try
        {
            string texto = File.ReadAllText(Path.GetFullPath("texto.txt")), textoAlReves = "";
            for(int i = texto.Length - 1; i >= 0; i--)
            {
                textoAlReves += texto[i];
            }
            Console.WriteLine(textoAlReves);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("El archivo no se ha encontrado.");
        }
    }
}

