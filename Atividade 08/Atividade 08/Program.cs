// See https://aka.ms/new-console-template for more information
Console.Write("Digite um valor (não pode ser zero): ");
int valor = int.Parse(Console.ReadLine());

	if (valor == 0)
	{
		Console.WriteLine("Valor inválido! Zero não é permitido.");
	}
	else if (valor > 0)
	{
		Console.WriteLine("O valor é POSITIVO.");
	}
	else
	{
		Console.WriteLine("O valor é NEGATIVO.");
	}
