class Program
{
    static void Main()
    {
        string identificação, nome, cidade, tipodeevento;
        int idade;
        long código;
        bool realização;

        Console.WriteLine("============================");
        Console.WriteLine("SISTEMA DE CADASTRO DE EVENTO");
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

        Console.Write("Código de evento: ");
        código = long.Parse(Console.ReadLine());

        Console.Write("Tipo de evento: ");
        tipodeevento = Console.ReadLine();


        Console.WriteLine("Já fez eventos antes? (true/false): ");
        realização = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("============================");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("============================");
        Console.WriteLine("DADOS DO SISTEMA");
        Console.WriteLine("============================");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("CPF: " + identificação);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Código de evento: " + código);
        Console.WriteLine("Tipo de envento: " + tipodeevento);
        Console.WriteLine("Já fez eventos antes? (true/false): " + realização);

        Console.WriteLine();
        Console.WriteLine("============================");
        Console.WriteLine();


    }
}
