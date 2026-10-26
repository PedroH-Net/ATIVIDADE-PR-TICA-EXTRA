class Program
{
    static void Main()
    {
        string nome;
        int idade;
        string cidade;
        string curso;
        decimal altura;
        char inicialdonome;
        bool trabalha;
        bool estuda;

        Console.WriteLine("=====================");
        Console.WriteLine("PERFIL DO ESTUDANTE");
        Console.WriteLine("=====================");
        Console.WriteLine();

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Curso: ");
        curso = Console.ReadLine();

        Console.Write("Altura: ");
        altura = decimal.Parse(Console.ReadLine());

        Console.Write("Trabalha? (true/false): ");
        trabalha = bool.Parse(Console.ReadLine());

        Console.Write("Estuda? (true/false): ");
        estuda = bool.Parse(Console.ReadLine());

        inicialdonome = nome[0];

        Console.WriteLine();
        Console.Write("=====================");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("=====================");
        Console.WriteLine("DADOS DO ESTUDANTE");
        Console.WriteLine("=====================");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Curso: " + curso);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Inicial do nome: " + inicialdonome);
        Console.WriteLine("Trabalha? " + trabalha);
        Console.WriteLine("Estuda? " + estuda);

        Console.WriteLine();
        Console.WriteLine("=====================");
        Console.WriteLine();




    }
}
