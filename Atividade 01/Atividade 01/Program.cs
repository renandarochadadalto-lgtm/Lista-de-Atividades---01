// See https://aka.ms/new-console-template for more information
int A = 10;
int B = 20;
int aux;
Console.WriteLine($"O valor de A = {A} e o de B = {B}");
aux = A;
A = B;
B = aux;
Console.WriteLine($"O valor de A = {A} e o de B = {B}");
Console.ReadLine();