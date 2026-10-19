Random random = new Random();
int vagasdisponiveis = random.Next(1, 51); 
double tarifanormal = 10;
double tarifareduzida = 5;
int movimentacao = 0;
bool sistemaAtivo = true;

Console.WriteLine("Bem-vindo ao sistema de controle de estacionamento!");
while (sistemaAtivo)
{
    Console.WriteLine("\n--- MENU ESTACIONAMENTO ---");
    Console.WriteLine("1 - Entrada de veículo");
    Console.WriteLine("2 - Saída de veículo");
    Console.WriteLine("3 - Quantidade de veículos");
    Console.WriteLine("4 - Encerrar o sistema");
    Console.Write("Escolha uma opção: ");

    switch (int.Parse(Console.ReadLine()!))
    {
        case 1:
            Console.WriteLine("Entrada de veículo cadastrada.");
            vagasdisponiveis--;
            movimentacao++;
            break;

        case 2:
            Console.WriteLine("Digite o tempo de permanência do veículo em horas:");
            int tempopermanencia = int.Parse(Console.ReadLine()!);
            double tarifa = tempopermanencia <= 2 ? tarifareduzida : tarifanormal;
            Console.WriteLine($"Saída de veículo registrada. Tarifa a pagar: R${tarifa}");
            vagasdisponiveis++;
            movimentacao++;
            break;

        case 3:
            Console.WriteLine($"Quantidade de veículos estacionados: {vagasdisponiveis}");
            break;

        case 4:
            Console.WriteLine("Encerrando o sistema...");
            for (int i = 0; i < movimentacao; i++)
            {
                Console.WriteLine($"Movimentação {i + 1} registrada.");
            }
            Console.WriteLine($"Total de movimentações: {movimentacao}");
            sistemaAtivo = false; 
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            continue; 
    }

    if (!sistemaAtivo) break;

    Console.WriteLine("\nDeseja realizar outra operação? (s/n)");
    string resposta = Console.ReadLine()!;

    if (resposta == "n")
    {
        Console.WriteLine("Encerrando o sistema... Até logo!");
        sistemaAtivo = false; //
    }
}
