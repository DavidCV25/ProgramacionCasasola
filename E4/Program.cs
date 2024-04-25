namespace Ejercicio_4;

public class Program
{
    static void Main(string[] args)
    {
        string contenedor = args[0];

        Console.WriteLine($"Contenido del fichero {Path.GetFileName(contenedor)}:");
        Console.Write(File.ReadAllText(contenedor));
    }
}