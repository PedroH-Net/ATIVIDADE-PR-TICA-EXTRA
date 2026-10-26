class Program
{
    static void Main()
    {
        string nome;
        long matricula;
        int idade;
        string cidade;
        string turno;
        bool trabalho;

        Console.WriteLine("=====================================");
        Console.WriteLine("INSCRIÇÃO PARA CURSO");
        Console.WriteLine("=====================================");
        Console.WriteLine();

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Matrícula: ");
        matricula = long.Parse(Console.ReadLine());

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Turno: ");
        turno = Console.ReadLine();

        Console.Write("Trabalha? (true/false): ");
        trabalho = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=======================================");
        Console.WriteLine("DADOS DO CURSO");
        Console.WriteLine("=======================================");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Matrícula: " + matricula);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Turno: " + turno);
        Console.WriteLine("Trabalha: " + trabalho);

        Console.WriteLine("=======================================");

        Console.WriteLine("=======================================");
        Console.WriteLine("MATRÍCULA REGISTRADA COM SUCESSO");
        Console.WriteLine("=======================================");




    }
}
