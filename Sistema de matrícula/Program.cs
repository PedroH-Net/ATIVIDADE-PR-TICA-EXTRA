class Program
{
    static void Main(string[] args)
    {
        string nomedoaluno;
        int idade;
        string curso;
        string cidade;
        long numerodematricula;
        string turno;
        bool ativo;

        Console.WriteLine("===========================================");
        Console.WriteLine("SISTEMA DE MATRÍCULA");
        Console.WriteLine("===========================================");
        Console.WriteLine();

        Console.Write("Nome do aluno: ");
        nomedoaluno = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Curso: ");
        curso = Console.ReadLine();

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Númerodematrícula: ");
        numerodematricula = long.Parse(Console.ReadLine());

        Console.Write("Turno: ");
        turno = Console.ReadLine();

        Console.Write("Aluno está ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.WriteLine("===========================================");

        Console.WriteLine();
        Console.WriteLine("===========================================");
        Console.WriteLine("DADOS DO SISTEMA");
        Console.WriteLine("===========================================");
        Console.WriteLine();
        Console.WriteLine("Nome do aluno: " + nomedoaluno);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Curso: " + curso);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Númerodematrícula: " + numerodematricula);
        Console.WriteLine("Turno: " + turno);
        Console.WriteLine("Aluno está ativo: " + ativo);
        Console.WriteLine("===========================================");

    }
}
