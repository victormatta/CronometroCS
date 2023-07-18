namespace StopWatchCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Seja Bem-vindo ao seu cronômetro:)");
            Console.WriteLine("Digite qual tipo de cronômetro deseja usar: ");
            Console.WriteLine("s - Tempo em segundos");
            Console.WriteLine("m - Tempo em minutos");
            Console.WriteLine("f - Sair do programa");

            string option = Console.ReadLine().ToLower();

            if (option == "s")
            {
                Console.WriteLine("Digite o tempo em segundos: ");
                int time = int.Parse(Console.ReadLine());

                PreStopWatch(time);
                Menu();
            }

            if (option == "m")
            {
                Console.WriteLine("Digite o tempo em minutos: ");
                int time = int.Parse(Console.ReadLine());
                int multiply = 60;

                PreStopWatch(time * multiply);
                Menu();
            }

            if (option == "f")
            {
                System.Environment.Exit(0);
            }
        }

        public static void PreStopWatch(int time)
        {
            Console.WriteLine("READY");
            Thread.Sleep(1500);
            Console.WriteLine("SET");
            Thread.Sleep(1200);
            Console.WriteLine("GOO!!");
            Thread.Sleep(1000);

            StopWatch(time);
        }

        public static void StopWatch(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Menu();
        }
    }
}