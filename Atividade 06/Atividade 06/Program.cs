// See https://aka.ms/new-console-template for more information
Console.Write("Digite o salário mensal atual: R$ ");
double salarioAtual = double.Parse(Console.ReadLine());
Console.Write("Digite o percentual de reajuste (%): ");
double percentualReajuste = double.Parse(Console.ReadLine());
double novoSalario = salarioAtual * (1 + percentualReajuste / 100);
Console.WriteLine($"\nO novo salário é: R$ {novoSalario:F2}");