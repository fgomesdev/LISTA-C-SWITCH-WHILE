Console.WriteLine("Caixa Eletrônico");
Console.WriteLine("saldo inicial: R$ 1000,00");
double saldo = 1000;
Console.WriteLine("Deseja Retirar algum valor? (s/n)");
string resposta = Console.ReadLine()!;
double retirar = 0;

switch(resposta)
{
case "s":
Console.WriteLine("Quanto deseja retirar?");
retirar = double.Parse(Console.ReadLine()!);
break;

default:
Console.WriteLine("Tenha um Belo dia");
break;
}

saldo -= retirar;
Console.WriteLine($"Seu saldo é: R$ {saldo:F2}");
