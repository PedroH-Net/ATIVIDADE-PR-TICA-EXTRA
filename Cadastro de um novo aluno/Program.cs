class Program
{
    static void Main()
    {
        string nomeCompleto;
        int idade;
        string cidadeOndemora;
        decimal altura;
        char primeiraletradonome;
        bool matriculado;

        Console.WriteLine("====================");
        Console.WriteLine("CADASTRO DO ALUNO");
        Console.WriteLine("====================");
        Console.WriteLine();

        Console.Write("Nome completo: ");
        nomeCompleto = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade onde mora: ");
        cidadeOndemora = Console.ReadLine();

        Console.Write("Altura: ");
        altura = decimal.Parse(Console.ReadLine());

        Console.Write("Está matriculado? (true/false): ");
        matriculado = bool.Parse(Console.ReadLine());

        primeiraletradonome = nomeCompleto[0];

        Console.WriteLine();
        Console.WriteLine("====================");
        Console.WriteLine("DADOS DO ALUNO");
        Console.WriteLine("====================");
        Console.WriteLine();

        Console.Write("Nome completo: " + nomeCompleto);
        Console.WriteLine();
        Console.Write("Idade: " + idade);
        Console.WriteLine();
        Console.Write("Cidade onde mora: " + cidadeOndemora);
        Console.WriteLine();
        Console.Write("Altura: " + altura);
        Console.WriteLine();
        Console.Write("Primeira letra do seu nome: " + primeiraletradonome);
        Console.WriteLine();
        Console.Write("Está matriculado? " + matriculado);

        Console.WriteLine();
        Console.WriteLine("====================");
        Console.ReadLine();

    }
}

