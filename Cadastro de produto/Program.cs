class Program
{
    static void Main()
    {
        string nome;
        string código;
        string categoria;
        decimal preço;
        int quantidadeemestoque;
        char inicialdacategoria;
        bool produtodisponívelparavenda;

        Console.WriteLine("----------------------------------");
        Console.WriteLine("CADASTRO DE PRODUTO");
        Console.WriteLine("----------------------------------");
        Console.WriteLine();

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Código: ");
        código = Console.ReadLine();

        Console.Write("Categoria: ");
        categoria = Console.ReadLine();

        Console.Write("Preço: ");
        preço = decimal.Parse(Console.ReadLine());

        Console.Write("Quantidade em estoque: ");
        quantidadeemestoque = int.Parse(Console.ReadLine());

        Console.Write("Produto disponível para venda? (true/false): ");
        produtodisponívelparavenda = bool.Parse(Console.ReadLine());

        inicialdacategoria = categoria[0];

        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("DADOS DO PRODUTO");
        Console.WriteLine("----------------------------------");
        Console.WriteLine();

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Código: " + código);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Preço: " + preço);
        Console.WriteLine("Quantidade em estoque: " + quantidadeemestoque);
        Console.WriteLine("Inicial da categoria: " + inicialdacategoria);
        Console.WriteLine("Produto disponível para venda? " + produtodisponívelparavenda);

        Console.WriteLine();

        Console.WriteLine("----------------------------------");

    }
}