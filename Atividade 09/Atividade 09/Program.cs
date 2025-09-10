// See https://aka.ms/new-console-template for more information
Console.Write("Digite o número de maçãs compradas: ");
int numMacas = int.Parse(Console.ReadLine());

double preco;

if (numMacas < 12)
{
	preco = 1.30;
}
else
{
	preco = 1.00;
}

double custoTotal = numMacas * preco;

Console.WriteLine($"O custo total da compra é: R${custoTotal:F2}");
