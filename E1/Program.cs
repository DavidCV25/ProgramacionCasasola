namespace Ejercicio_1;

public class Program()
{
    public static void Main()
    {
        string fichero = "c:/directorio1/directorio2/directorio3/texto.txt";
        Console.WriteLine($"Ruta:                                   {fichero}");
        Console.WriteLine($"Extension:                              {Path.GetExtension(fichero)}");
        Console.WriteLine($"Nombre Fichero Completo:                {Path.GetFileName(fichero)}");
        Console.WriteLine($"Nombre Fichero Sin Extension:           {Path.GetFileNameWithoutExtension(fichero)}");
        Console.WriteLine($"Ruta Completa Directorio actual:        {Path.GetDirectoryName(fichero)}");
        Console.WriteLine($"Unidad y Raiz de la Ruta:               {Path.GetPathRoot(fichero)}");
        Console.WriteLine($"Obtener Ruta absoluta Completa:         {Path.GetFullPath("fichero.txt")}");
    }
}