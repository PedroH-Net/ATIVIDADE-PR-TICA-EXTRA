class Program
{
    static void Main()
    {
        string nome, produto, categoriadoproduto;
        int idade, quantidadedeproduto;
        double valordoproduto;
        long código;
        bool pedidoativo;

        Console.WriteLine("============================");
        Console.WriteLine("SISTEMA DE PEDIDO");
        Console.WriteLine("============================");
        Console.WriteLine();



        Console.Write("Qual seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Qual sua idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Qual sua produto: ");
        produto = Console.ReadLine();

        Console.Write("Quantidade: ");
        quantidadedeproduto = int.Parse(Console.ReadLine());

        Console.Write("Categoria do produto: ");
        categoriadoproduto = Console.ReadLine();

        Console.Write("Código do produto: ");
        código = long.Parse(Console.ReadLine());

        Console.Write("Valor do produto: ");
        valordoproduto = double.Parse(Console.ReadLine());

        Console.Write("Pedido ativo (true/false): ");
        pedidoativo = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("============================");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("============================");
        Console.WriteLine("DADOS DO PEDIDO  ");
        Console.WriteLine("============================");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Qual sua produto: " + produto);
        Console.WriteLine("Quantidade: " + quantidadedeproduto);
        Console.WriteLine("Categoria: " + categoriadoproduto);
        Console.WriteLine("Código: " + código);
        Console.WriteLine("Valor do produto:  R$" + valordoproduto);
        Console.WriteLine("Pedido ativo (true/false): " + pedidoativo);

        Console.WriteLine();
        Console.WriteLine("============================");
        Console.WriteLine();


    }
}
