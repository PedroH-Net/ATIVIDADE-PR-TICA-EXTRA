class Program
{ static void Main()
    {
        string identificação, nome, cidade, motivodeatendimento;
        int idade;
        long código;
        bool atendimentoconcluido;

        Console.WriteLine("============================");
        Console.WriteLine("SISTEMA DE ATENDIMENTO");
        Console.WriteLine("============================");
        Console.WriteLine();

        

        Console.Write("Qual seu nome: ");
        nome = Console.ReadLine();
        
        Console.Write("Qual sua idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Qual sua cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Qual seu CPF: ");
        identificação = Console.ReadLine();

        Console.Write("Código: ");
        código = long.Parse(Console.ReadLine());

        Console.Write("Motivo: ");
        motivodeatendimento = Console.ReadLine();

        Console.Write("Atendimento concluido (true/false): ");
        atendimentoconcluido = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("============================");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("============================");
        Console.WriteLine("DADOS DO ATENDIMENTO");
        Console.WriteLine("============================");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("CPF: " + identificação);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Código: " + código);
        Console.WriteLine("Motivo: " + motivodeatendimento);
        Console.WriteLine("Atendimento concluido (true/false): " + atendimentoconcluido);

        Console.WriteLine();
        Console.WriteLine("============================");
        Console.WriteLine();


    }
    }
