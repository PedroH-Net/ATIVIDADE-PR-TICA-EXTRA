class Program
{
    static void Main()
    {
        string identificação;
        int idade;
        string cidade;
        long codigo;
        string situação;

        Console.WriteLine("===========================");
        Console.WriteLine("CADASTRO DO CLIENTE");
        Console.WriteLine("===========================");
        Console.WriteLine();

        Console.Write("Identificação: ");
        identificação = Console.ReadLine();

        Console.Write("idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("cidade: ");
        cidade = Console.ReadLine();

        Console.Write("código: ");
        codigo = long.Parse(Console.ReadLine());

        Console.Write("situação: ");
        situação = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("===========================");
        Console.WriteLine("DADOS DO CLIENTE");
        Console.WriteLine("===========================");

        Console.WriteLine("Identificação: " + identificação);
        Console.WriteLine("idade: " + idade);
        Console.WriteLine("cidade: " + cidade);
        Console.WriteLine("código: " + codigo);
        Console.WriteLine("situação: " + situação);

    }
}