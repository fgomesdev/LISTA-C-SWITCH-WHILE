Console.WriteLine("===== CARDÁPIO =====");
Console.WriteLine("CODIGO 1 - Hambúrguer    - R$ 18,00");
Console.WriteLine("CODIGO 2 - Pizza         - R$ 32,00");
Console.WriteLine("CODIGO 3 - Pastel        - R$ 10,00");
Console.WriteLine("CODIGO 4 - Refrigerante  - R$ 6,00");
Console.WriteLine("====================");
Console.Write("Escolha o código do produto: ");
string produto;
double preco;
        switch (int.Parse(Console.ReadLine()!))
        {
            case 1:
                produto = "Hambúrguer";
                preco = 18.00;
                break;
            case 2:
                produto = "Pizza";
                preco = 32.00;
                break;
            case 3:
                produto = "Pastel";
                preco = 10.00;
                break;
            case 4:
                produto = "Refrigerante";
                preco = 6.00;
                break;
            default:
                Console.WriteLine("Código inválido!");
                return;
        }

Console.WriteLine($"Produto: {produto}");
Console.WriteLine($"Preço unitário: {preco:F2}");

Console.WriteLine("Voce possui cupom de desconto?(opcional)");
string cupominserido = Console.ReadLine()!;
double descontao = cupominserido == "desconto" ? 0.10 : 0.00;

Console.Write("Digite a quantidade: ");
int quantidade = int.Parse(Console.ReadLine()!);
double total = preco * quantidade;

Console.WriteLine($"Total do pedido: {total - total * descontao:F2}");