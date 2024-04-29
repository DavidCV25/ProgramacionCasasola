namespace Ejercicio_5;

public class Program
{
    static void Main()
    {
        string nomF1 = "Pedro.txt";
        string nomF2 = "Pedro.txt";

        
        Console.WriteLine(ConcatenarNombres(nomF1, nomF2));
    }

    public static string ConcatenarNombres(string nomF1, string nomF2)
    {
        return Path.GetFileNameWithoutExtension(nomF1) + nomF2;
    }
}