class Program
{
    static void Main(string[] args)
    {
        //Nomes das variáveis alterados para melhor compreensão
        string nome;
        int idade;
        string cidade;
        double altura;

        //Add visualização das informações do cliente
        Console.WriteLine("============================");
        Console.WriteLine("iNFORMAÇÕES DE CLIENTE");
        Console.WriteLine("============================");
        Console.WriteLine();



        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Altura: ");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine("============================");
        Console.WriteLine();

        //Add visualização dos dados do cliente
        Console.WriteLine("============================");
        Console.WriteLine("DADOS DO CLIENTE");
        Console.WriteLine("============================");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Altura: " + altura);

        Console.WriteLine("============================");
        //Um programa funcionar não significa automaticamente que ele está bem desenvolvido porque é preciso facilitar a compreensão do programador e da pessoa que o utiliza.
    }
}