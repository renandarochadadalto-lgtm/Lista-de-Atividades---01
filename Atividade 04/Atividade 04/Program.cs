// See https://aka.ms/new-console-template for more information
int idade;
int ano;
int mes;
int dia;
Console.WriteLine("Escreva a sua idade atual: ");
idade = int.Parse(Console.ReadLine()!);
Console.WriteLine("Escreva quantos meses se passaram desde o seu último aniversário:");
mes = int.Parse(Console.ReadLine()!);
Console.WriteLine("Escreva quantos dias se passaram desde o dia do mês que você nasceu:");
dia = int.Parse(Console.ReadLine()!);
Console.WriteLine($"A sua idade atual em dias é: {(365 * idade) + (30 * mes) + (dia)}");

