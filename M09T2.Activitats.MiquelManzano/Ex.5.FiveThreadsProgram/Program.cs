internal class Program
{
    private static void Main(string[] args)
    {
        // L'ordre d'execució no està garantit, perque cada fil va a la seva.
        WithOutSleep();
        // Aquí garantim la seva ordre retardant el temps d'execució entre fil i fil.
        WithSleep();
    }

    public static void WithOutSleep()
    {
        for (int i = 1; i <= 5; i++)
        {
            int numeroFil = i;
            Thread fil = new Thread(() =>
            {
                Console.WriteLine($"Hola! Sóc el fil número {numeroFil}");
            });
            fil.Start();
        }
    }

    public static void WithSleep()
    {
        for (int i = 5; i >= 1; i--)
        {
            int numeroFil = i;
            Thread fil = new Thread(() =>
            {
                Thread.Sleep((5 - numeroFil) * 500);
                Console.WriteLine($"Hola! Sóc el fil número {numeroFil}");
            });
            fil.Start();
        }
    }
}
