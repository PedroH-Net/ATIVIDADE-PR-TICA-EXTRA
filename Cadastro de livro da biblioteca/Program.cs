class Program
{
    static void Main()
{
        string titulo;
        string autor;
        int anodepublicação;
        long codigo;
        decimal preço;
        string categoria;
        bool disponível;

        Console.WriteLine("===================================");
        Console.WriteLine("SISTEMA DE CADASTRO DE LIVRO");
        Console.WriteLine("===================================");
        Console.WriteLine();

        Console.Write("Título: "); 
        titulo = Console.ReadLine();

        Console.Write("Autor: ");
        autor = Console.ReadLine();

        Console.Write("Ano de Publicação: ");
        anodepublicação = int.Parse(Console.ReadLine());

        Console.Write("Código: ");
        codigo = long.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        preço = decimal.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        categoria = Console.ReadLine();

        Console.Write("Disponível (true/false): ");
        disponível = bool.Parse(Console.ReadLine());

        Console.WriteLine("===================================");

        Console.WriteLine();

        Console.WriteLine("===================================");
        Console.WriteLine("DADOS DO LIVRO");
        Console.WriteLine("===================================");
        Console.WriteLine();

        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Ano de Publicação: " + anodepublicação);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Preço: " + preço);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Disponível: " + disponível);

        Console.WriteLine("===================================");

        Console.WriteLine("===================================");
        Console.WriteLine("CADASTRO CONCLUIDO COM SUCESSO");
        Console.WriteLine("===================================");

    }
    }
