class Program {
    static void Main() {
        bool running = true;

        while (running == true) {
            Console.WriteLine("Escolha o problema a ser executado:");
            Console.WriteLine("1 - Problema 06");
            Console.WriteLine("2 - Problema 07");
            Console.WriteLine("3 - Problema 08");
            Console.WriteLine("4 - Fechar");
            int userChoice = int.Parse(Console.ReadLine());

            while (userChoice < 1 || userChoice > 4) {
                Console.WriteLine("Escolha o problema a ser executado:");
                Console.WriteLine("1 - Problema 06");
                Console.WriteLine("2 - Problema 07");
                Console.WriteLine("3 - Problema 08");
                Console.WriteLine("4 - Fechar");
                userChoice = int.Parse(Console.ReadLine());
            }

            switch (userChoice) {
                case 1:
                    Problema06();
                    break;
                case 2:
                    Problema07();
                    break;
                case 3:
                    Problema08();
                    break;
                case 4:
                    Console.WriteLine("Encerrando Sistema...\n");
                    Thread.Sleep(250);
                    Console.WriteLine(".\n");
                    Thread.Sleep(250);
                    Console.WriteLine(".\n");
                    Thread.Sleep(250);
                    Console.WriteLine(".\n");
                    Thread.Sleep(250);
                    Console.WriteLine(".\n");
                    Thread.Sleep(250);
                    Console.WriteLine(".\n");
                    Thread.Sleep(250);
                    Console.WriteLine(".\n");
                    Thread.Sleep(250);
                    Console.WriteLine(".\n");
                    Thread.Sleep(250);
                    Console.WriteLine(".\n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...\n");
                    Console.ReadLine();
                    running = false;
                    break;
            }
        }
    }

    static void Problema06() {
        Console.WriteLine("Oi!");
    }
    static void Problema07() {
        Console.WriteLine("Oi!");        
    }
    static void Problema08() {
        Console.WriteLine("Oi!");
    }
}