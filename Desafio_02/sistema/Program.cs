class Program {
    static void Main() {
        bool runing = true;

        while (runing == true) {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - EX01 - Calcular rendimento de um investimento");
            Console.WriteLine("2 - EX02 - Calcular rendimento de 6 meses");
            Console.WriteLine("3 - EX03 - Calcular rendimento obtendo todos os valores do usuário");
            Console.WriteLine("4 - EX04 - Calcular rendimento considerando um saque");
            Console.WriteLine("5 - EX05 - Descobrir o valor a ser aplicado");
            Console.WriteLine("6 - ENCERRAR SISTEMA");
            Console.Write("\n-> ");
            int userChoice = int.Parse(Console.ReadLine());

            while (userChoice < 1 || userChoice > 6) {
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1 - EX01 - Calcular rendimento de um investimento");
                Console.WriteLine("2 - EX02 - Calcular rendimento de 6 meses");
                Console.WriteLine("3 - EX03 - Calcular rendimento obtendo todos os valores do usuário");
                Console.WriteLine("4 - EX04 - Calcular rendimento considerando um saque");
                Console.WriteLine("5 - EX05 - Descobrir o valor a ser aplicado");
                Console.WriteLine("6 - ENCERRAR SISTEMA");
                Console.Write("\n-> ");
                userChoice = int.Parse(Console.ReadLine());
            }

            double tariff;
            double yearTariff;
            double atualValue;
            double futureValue;
            double perMonth;
            double secPerMonth;
            double endValue;
            double withDraw;
            double beforeWithdraw;

            switch (userChoice) {
                case 1:
                    tariff = 5.30 / 100;
                    Console.Write("\nDigite o valor a ser aplicado\n-> ");
                    atualValue = double.Parse(Console.ReadLine());
                    Console.Write("\nDigite o periodo em meses\n-> ");
                    perMonth = double.Parse(Console.ReadLine());

                    endValue = atualValue * Math.Pow((1 + tariff), perMonth);

                    Console.Write("\n-----------------------------------------------\n");
                    Console.Write("--| VALOR ATUAL | % JUROS | REND. ACUMULADO |--\n");
                    Console.Write($"--| {atualValue.ToString("C"),10} | {tariff * 100,5} % | {endValue.ToString("C"),15} |--\n");
                    Console.Write("-----------------------------------------------\n\n");

                    break;
                case 2:
                    tariff = 1.25 / 100;
                    Console.Write("\nDigite o valor a ser aplicado\n-> ");
                    atualValue = double.Parse(Console.ReadLine());
                    int period = 1;
                    
                    Console.Write("\n---------------------------------------------------------------------------\n");
                    Console.Write("--| PERÍODO | VALOR ATUAL | % JUROS | VAL. RENDIMENTO | REND. ACUMULADO |--\n");

                    while (period <= 6) {
                        endValue = atualValue * Math.Pow((1 + tariff), period);
                        Console.Write($"--| {period,7} | {atualValue.ToString("C"),10} | {tariff * 100,5} % | {(endValue - atualValue).ToString("C"),15} | {endValue.ToString("C"),15} |--\n");
                        period++;
                    }
                    Console.Write("---------------------------------------------------------------------------\n");
                    break;
                case 3:
                    Console.Write("\n\nDigite a percentagem de juros (apenas números)\n-> ");
                    tariff = double.Parse(Console.ReadLine()) / 100;
                    Console.Write("\nDigite o valor a ser aplicado\n-> ");
                    atualValue = double.Parse(Console.ReadLine());
                    Console.Write("\nDigite o periodo em meses\n-> ");
                    perMonth = double.Parse(Console.ReadLine());

                    endValue = atualValue * Math.Pow((1 + tariff), perMonth);

                    Console.Write("\n-----------------------------------------------\n");
                    Console.Write("--| VALOR ATUAL | % JUROS | REND. ACUMULADO |--\n");
                    Console.Write($"--| {atualValue.ToString("C"),10} | {tariff * 100,5} % | {endValue.ToString("C"),15} |--");
                    Console.Write("\n-----------------------------------------------\n\n");
                    break;
                case 4:
                    tariff = 2.00 / 100;
                    perMonth = 1;
                    secPerMonth = 1;
                    beforeWithdraw = 0;
                    Console.Write("\nDigite o valor a ser aplicado\n-> ");
                    atualValue = double.Parse(Console.ReadLine());
                    
                    Console.Write("\n---------------------------------------------------------------------------\n");
                    Console.Write("--| PERÍODO | VALOR ATUAL | % JUROS | VAL. RENDIMENTO | REND. ACUMULADO |--\n");

                    while (perMonth <= 8) {
                        if (perMonth <= 5) {
                            endValue = atualValue * Math.Pow((1 + tariff), perMonth);
                            Console.Write($"--| {perMonth,7} | {atualValue.ToString("C"),10} | {tariff * 100,5} % | {(endValue - atualValue).ToString("C"),15} | {endValue.ToString("C"),15} |--\n");
                            beforeWithdraw = (endValue - atualValue);
                        }

                        if (perMonth == 5) { 
                            Console.Write("\nDigite o valor a ser sacado\n-> ");
                            withDraw = double.Parse(Console.ReadLine());
                            beforeWithdraw = beforeWithdraw + (atualValue - withDraw);
                            Console.Write("\n---------------------------------------------------------------------------\n");            
                        }
                        else if (perMonth >= 6) {
                            endValue = beforeWithdraw * Math.Pow((1 + tariff), secPerMonth);
                            Console.Write($"--| {perMonth,7} | {beforeWithdraw.ToString("C"),10} | {tariff * 100,5} % | {(endValue - beforeWithdraw).ToString("C"),15} | {endValue.ToString("C"),15} |--\n");
                            secPerMonth++;
                        }
                        perMonth++;
                    }                    
                    Console.Write("---------------------------------------------------------------------------\n");   
                    break;
                case 5:
                    tariff = 1.25 / 100; // Juros a.m.
                    tariff += 1; // para converter para a.a.
                    Console.Write("\nDigite o valor a ser atingido\n-> ");
                    futureValue = double.Parse(Console.ReadLine());
                    Console.Write("\nEm quanto tempo(EM ANOS)?\n-> ");
                    perMonth = double.Parse(Console.ReadLine());
                    yearTariff = ((Math.Pow((tariff), 12)) - 1); // Juros a.a.
                    int newPeriod = 1;
                    endValue = 0;
                        while (newPeriod <= perMonth) {
                            endValue = futureValue / Math.Pow((1 + yearTariff), newPeriod);
                            newPeriod++;
                        }

                    Console.Write("\n---------------------------------------------------------------------------\n");
                    Console.Write("--| PERÍODOS | VALOR A INVESTIR | % JUROS a.a. | VALOR A OBTER |--\n");
                    Console.Write($"--| {perMonth,3} Anos | {endValue.ToString("C"),16} | {yearTariff.ToString("P"),12} | {futureValue.ToString("C"),13} |--\n");
                    Console.Write("\n---------------------------------------------------------------------------\n");
                    break;
                case 6:
                    Console.WriteLine("\nEncerrando...");
                    Thread.Sleep(250);
                    Console.WriteLine("\n.");
                    Thread.Sleep(250);
                    Console.WriteLine("\n.");
                    Thread.Sleep(250);
                    Console.WriteLine("\n.");
                    Thread.Sleep(250);
                    Console.WriteLine("\n.");
                    Thread.Sleep(250);
                    Console.WriteLine("\n.");
                    Thread.Sleep(250);
                    Console.WriteLine("\n.");
                    Thread.Sleep(250);
                    Console.WriteLine("\n.");
                    Thread.Sleep(250);
                    Console.WriteLine("\n.");
                    Console.WriteLine("\nPressione qualquer tecla para fechar...");
                    Console.ReadLine();
                    runing = false;
                    break;
            }
        }
    }
}