// See https://aka.ms/new-console-template for more information
Console.Write("Digite o número total de eleitores: ");
int totalEleitores = int.Parse(Console.ReadLine());
Console.Write("Digite o número de votos brancos: ");
int votosBrancos = int.Parse(Console.ReadLine());
Console.Write("Digite o número de votos nulos: ");
int votosNulos = int.Parse(Console.ReadLine());
Console.Write("Digite o número de votos válidos: ");
int votosValidos = int.Parse(Console.ReadLine());
double percentualBrancos = (double)votosBrancos / totalEleitores * 100;
double percentualNulos = (double)votosNulos / totalEleitores * 100;
double percentualValidos = (double)votosValidos / totalEleitores * 100;
Console.WriteLine($"\nPercentual de votos brancos: {percentualBrancos:F2}%");
Console.WriteLine($"Percentual de votos nulos: {percentualNulos:F2}%");
Console.WriteLine($"Percentual de votos válidos: {percentualValidos:F2}%");