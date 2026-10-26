class Program
{
    static void Main()
    {
        string nome; // String para nome.
        int idade; // Int para números inteiros.
        string cidade; // String para nome da cidade.
        string cargo; // String para cargo.
        decimal salário; // Decimal para númeors decimais como os de dinheiro.
        char inicialFuncionário; // Char para inicial de funcionário.
        bool ativo; // Bool para verificar se o funcionário está ativo ou não.

        Console.WriteLine();
        Console.Write("IDENTIFICAÇÃO PROFISSIONAL");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Cargo: ");
        cargo = Console.ReadLine();

        Console.Write("Salário: ");
        salário = decimal.Parse(Console.ReadLine());

        Console.Write("Ativo: ");
        ativo = bool.Parse(Console.ReadLine());

        inicialFuncionário = nome[0];

        Console.WriteLine();
        Console.WriteLine("DADOS DO FUNCIONÁRIO");
        Console.WriteLine();

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Salário: " + salário);
        Console.WriteLine("Inicial do Funcionário: " + inicialFuncionário);
        Console.WriteLine("Ativo (true/false): " + ativo);

    }
}
