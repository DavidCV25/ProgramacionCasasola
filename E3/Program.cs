using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string origen = args[0];
        string destino = args[1];
        char caracter = args[2][0];
        try
        {
            using (StreamReader lector = new StreamReader(origen))
            {
                using (StreamWriter escritor = new StreamWriter(destino))
                {
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        string nuevaLinea = linea.Replace(caracter.ToString(), "");
                        escritor.WriteLine(nuevaLinea);
                    }
                }
            }
            Console.WriteLine($"Archivo copiado exitosamente excluyendo el carácter {caracter}");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("El archivo no se ha encontrado.");
        }
    }
}
