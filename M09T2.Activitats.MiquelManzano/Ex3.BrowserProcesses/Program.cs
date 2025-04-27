using System.Diagnostics;

internal class Program
{
    //Si obres més pestanyes, s'obren nous fils per gestionar cada pestanya independentment.
    private static void Main(string[] args)
    {
        foreach (Process p in Process.GetProcessesByName("firefox"))
        {
            Console.WriteLine($"Navegador: {p.ProcessName} - PID: {p.Id}");
            Console.WriteLine($"Number Threads: {p.Threads.Count}");
            foreach (ProcessThread fil in p.Threads)
            {
                Console.WriteLine($"    Fil ID: {fil.Id} | Inici: {fil.StartTime} | Prioritat: {fil.PriorityLevel}");
            }
        }
    }
}