namespace Ejercicio_6;

public class Program
{
    public static void Main()
    {
        string narracionGolIniesta = "Le van a agarrar intenta irse se va Navas, vamos, se desmarca Torres,\nel mundo contra Navas, que tiene ahí velocidad para ir, consigue enviar la pelota\npara el tacon de Iniesta, llega Cesc, aparece de nuevo Navas q se desfonda,\nentrega el balón para Fernando Torres, prepara el centro,\nla pide Iniesta, el rechaze para Cesc, Cesc para Iniesta\nno hay fuera de juego, vamos Iniesta y\nGOOOOOOOLLLL!!!!\n";
        CrearFichero("Texto.txt", narracionGolIniesta);
        ListarFichero("Texto.txt");
    }

    public static void CrearFichero(string fi, string texto)
    {
        using (StreamWriter escritor = File.CreateText(fi))
        {
            escritor.WriteLine(texto);
        }
    }
    
    public static void ListarFichero(string fi)
    {
        Console.WriteLine(File.ReadAllText(Path.GetFullPath(fi)));
    }

}