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
        FutureRent newCalc = new FutureRent();
    }
    static void Problema07() {
        CalcWithDraw newCalc = new CalcWithDraw();
    }
    static void Problema08() {
        Console.WriteLine("\n-------------------------------------------------");
        Console.WriteLine("\nDe acordo com o enunciado, a questão é igual a 07\n");
        Console.WriteLine("-------------------------------------------------\n");
    }
}

class FutureRent {
    private double atualValue;
    private double futureValue;
    private double Tariff;
    private double dayTariff;
    private int months = 8;
    private int days = 10;

    public FutureRent() {
        Console.Write("Quantos cálculos deseja fazer? ");
        int numCalcs = int.Parse(Console.ReadLine());
        int counter = 1;

        while (counter <= numCalcs) {
            Console.Write("\n\nDigite a percentagem de juros (apenas números)\n-> ");
            this.Tariff = double.Parse(Console.ReadLine()) / 100;
            this.dayTariff = Tariff / 20;
            Console.Write("\nDigite o valor a ser aplicado\n-> ");
            this.atualValue = double.Parse(Console.ReadLine());

            // Calculo do período em meses
            this.futureValue = this.atualValue * Math.Pow((1 + this.Tariff),this.months );

            Console.Write("\n-----====[ CÁLCULO DO PERÍODO MENSAL ]====-----\n");
            Console.Write("--| VALOR ATUAL | % JUROS | REND. ACUMULADO |--\n");
            Console.Write($"--| {this.atualValue.ToString("C"),10} | {this.Tariff * 100,5} % | {this.futureValue.ToString("C"),15} |--");
            Console.Write("\n-----------------------------------------------\n\n");

            // Calculo do período em dias
            this.atualValue = this.futureValue;
            this.futureValue = this.atualValue * Math.Pow((1 + this.dayTariff),this.days );    

            Console.Write("-----====[ CÁLCULO DO PERÍODO DIÁRIO ]====-----\n");
            Console.Write("--| VALOR ATUAL | % JUROS | REND. ACUMULADO |--\n");
            Console.Write($"--| {this.atualValue.ToString("C"),10} | {this.dayTariff * 100,5} % | {this.futureValue.ToString("C"),15} |--");
            Console.Write("\n-----------------------------------------------\n\n");
            Console.Write($"Valor Total --> {this.futureValue.ToString("C")}\n\n");
            counter++;
        }
    }
}

class CalcWithDraw {
    private double atualValue;
    private double futureValue;
    private double withDraw;
    private double Tariff;
    private double dayTariff;
    private int months = 8;
    private int days = 10;
    public CalcWithDraw() {
        Console.Write("Quantos cálculos deseja fazer? ");
        int numCalcs = int.Parse(Console.ReadLine());
        int counter = 1;        
        int perMonth = 1;
        int secPerMonth = 1;
        double beforeWithdraw = 0;
        double beforeMonths = 0;

        while (counter <= numCalcs) {
            Console.Write("\n\nDigite a percentagem de juros (apenas números)\n-> ");
            this.Tariff = double.Parse(Console.ReadLine()) / 100;
            Console.Write("\nDigite o valor a ser aplicado\n-> ");
            this.atualValue = double.Parse(Console.ReadLine());
            this.dayTariff = Tariff / 20;
            perMonth = 1;
            secPerMonth = 1;
            beforeWithdraw = 0;
            
                        
            Console.Write("\n-----------======[ TABELA DE VALORES DO RENDIMENTO MENSAL ]======----------\n");
            Console.Write("--| PERÍODO | VALOR ATUAL | % JUROS | VAL. RENDIMENTO | REND. ACUMULADO |--\n");

            while (perMonth <= this.months) {
                if (perMonth <= 5) {
                    this.futureValue = this.atualValue * Math.Pow((1 + this.Tariff), perMonth);
                    Console.Write($"--| {perMonth,7} | {atualValue.ToString("C"),10} | {this.Tariff * 100,5} % | {(this.futureValue - this.atualValue).ToString("C"),15} | {this.futureValue.ToString("C"),15} |--\n");
                    beforeWithdraw = (this.futureValue - this.atualValue);
                }

                if (perMonth == 5) { 
                    Console.Write("\nDigite o valor a ser sacado: ");
                    withDraw = double.Parse(Console.ReadLine());
                    beforeWithdraw = beforeWithdraw + (atualValue - withDraw);
                    Console.Write("\n---------------------------------------------------------------------------\n");            
                }
                else if (perMonth >= 6) {
                    this.futureValue = beforeWithdraw * Math.Pow((1 + this.Tariff), secPerMonth);
                    Console.Write($"--| {secPerMonth,7} | {beforeWithdraw.ToString("C"),10} | {this.Tariff * 100,5} % | {(this.futureValue - beforeWithdraw).ToString("C"),15} | {this.futureValue.ToString("C"),15} |--\n");                    
                    beforeMonths = this.futureValue;
                    secPerMonth++;

                }
                perMonth++;
            }
            counter++;
        }

        counter = 1;

        Console.Write("\n-----------======[ TABELA DE VALORES DO RENDIMENTO DIÁRIO ]======----------\n");
        Console.Write("--| PERÍODO | VALOR ATUAL | % JUROS | VAL. RENDIMENTO | REND. ACUMULADO |--\n");

        while (counter <= this.days) {
            this.futureValue = beforeMonths * Math.Pow((1 + this.dayTariff), counter);
            Console.Write($"--| {counter,7} | {beforeMonths.ToString("C"),10} | {this.dayTariff * 100,5} % | {(this.futureValue - beforeMonths).ToString("C"),15} | {this.futureValue.ToString("C"),15} |--\n");
            counter++;
        }
        Console.Write("\n---------------------------------------------------------------------------\n");  
    }
}