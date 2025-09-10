// See https://aka.ms/new-console-template for more information
Console.Write("Digite a nota da 1ª avaliação: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a nota da 2ª avaliação: ");
double nota2 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2) / 2;

Console.WriteLine($"\nA média do aluno é: {media:F2}");

if (media >= 6.0)
{
	Console.WriteLine("O aluno foi APROVADO!");
}
else
{
	Console.WriteLine("O aluno NÃO FOI APROVADO.");
}
