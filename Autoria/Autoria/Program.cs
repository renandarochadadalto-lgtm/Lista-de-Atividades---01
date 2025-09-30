// See https://aka.ms/new-console-template for more information
{
        public string Nome;
public int Idade;
    }

    static void Main()
{
    List<Paciente> pacientes = new List<Paciente>();
    string opcao = "";

    while (opcao != "3")
    {
        Console.WriteLine("\n🏥 Cadastro Hospitalar");
        Console.WriteLine("1) Cadastrar paciente\n2) Listar pacientes\n3) Sair");
        Console.Write("Opção: ");
        opcao = Console.ReadLine();

        if (opcao == "1")
        {
            pacientes.Add(new Paciente
            {
                Nome = Console.ReadLineWithPrompt("Nome: "),
                Idade = int.Parse(Console.ReadLineWithPrompt("Idade: "))
            });
            Console.WriteLine("✅ Paciente cadastrado!");
        }
        else if (opcao == "2")
        {
            foreach (var p in pacientes)
                Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}");
        }
    }
    Console.WriteLine("👋 Sistema encerrado.");
}
}

static class Extensions
{
    public static string ReadLineWithPrompt(this Console c, string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }