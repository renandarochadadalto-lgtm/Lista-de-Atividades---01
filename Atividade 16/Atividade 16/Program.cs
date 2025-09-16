// See https://aka.ms/new-console-template for more information
Console.Write("Digite um número inteiro: ");
int n = int.Parse(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("Fatorial de número negativo não existe.");
}
else
{
    long fatorial = 1;

    for (int i = 1; i <= n; i++)
    {
        fatorial *= i;
    }

    Console.WriteLine($"{n}! = {fatorial}");
}
