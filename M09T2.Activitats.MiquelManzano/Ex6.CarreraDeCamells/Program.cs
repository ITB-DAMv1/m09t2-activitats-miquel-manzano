internal class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            int numeroCamell = i;
            Thread camell = new Thread(() => CorreCamell(numeroCamell, 50, 200));
            camell.Start();
        }
    }

    public static void CorreCamell(int numeroCamell, int minRetard, int maxRetard)
    {
        Random rnd = new Random();
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine($"Camell {numeroCamell}: {i}");
            Thread.Sleep(rnd.Next(minRetard, maxRetard));
        }
        Console.WriteLine($"Camell {numeroCamell} ha arribat!");
    }
}