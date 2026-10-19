Console.WriteLine("Estoque de Produtos");
int produto = 50;

bool acessar = true;

while(acessar)
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Realizar venda");
    Console.WriteLine("2 - Adicionar estoque");
    Console.WriteLine("3 - Consultar estoque");
    Console.WriteLine("4 - Gerar relatório");
    Console.WriteLine("5 - Sair");

    int opcao = int.Parse(Console.ReadLine()!);

    switch(opcao)
    {
        case 1:
            Console.WriteLine("Digite a quantidade a ser vendida: ");
            int venda = int.Parse(Console.ReadLine()!);
            if(venda <= produto)
            {
                produto -= venda;
                Console.WriteLine($"Venda realizada. Estoque atual: {produto}");
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque.");
            }
            break;

        case 2:
            Console.WriteLine("Digite a quantidade a ser adicionada ao estoque: ");
            int adicionar = int.Parse(Console.ReadLine()!);
            produto += adicionar;
            Console.WriteLine($"Estoque atualizado. Estoque atual: {produto}");
            break;

        case 3:
            string statusEstoque = produto < 10 ? "Estoque baixo" : "Estoque normal";
            Console.WriteLine($"Estoque atual: {produto} unidades. Status: {statusEstoque}");
            break;

        case 4:
            Console.WriteLine($"Relatório de estoque: {produto} unidades disponíveis.");
            break;

        case 5:
            acessar = false;
            Console.WriteLine("Saindo do sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}