namespace Ejercicio_9;

using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {  
        Stopwatch temp = new Stopwatch();
        temp.Start();
        DateTime fecha = DateTime.Now;      
        string lector = File.ReadAllText("Fichero.txt");

        using (StreamWriter escritor = File.CreateText("Fichero.txt"))
        {
            Console.WriteLine("Escriba lo que desee.");
            string texto = Console.ReadLine()!.ToString();          
            temp.Stop();
            lector += $"\nAbierto el {fecha:dd/MM/yy} a las {fecha: HH:mm:ss} por {Environment.UserName} y ha estado abierto durante {temp.Elapsed.Minutes:00}min {temp.Elapsed.Seconds:00}s {temp.Elapsed.Milliseconds:0000}ms";
            lector += $"\n Y ha escrito:\n {texto}\n";
            escritor.Write(lector);
        }
    }
}
