namespace Ejercicio_7
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                foreach(var fichero in args)
                {
                    Console.WriteLine($"{Path.GetFileName(fichero)}: {File.ReadAllText(fichero)} -");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo no se ha encontrado.");
            }
        }
    }
}