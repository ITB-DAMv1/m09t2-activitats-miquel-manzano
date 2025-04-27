using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Process[] processos = Process.GetProcesses();
        using (StreamWriter writer = new StreamWriter("processos.txt"))
        {
            foreach (Process p in processos)
            {
                Console.WriteLine($"Nom: {p.ProcessName} - PID: {p.Id}");
                writer.WriteLine($"Nom: {p.ProcessName} - PID: {p.Id}");
            }
        }
        // El fitxer es guarda dins de la carpeta debug del programa.
        Console.WriteLine("Llista de processos guardada a processos.txt");
    }
}