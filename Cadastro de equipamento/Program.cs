class Program
{
    static void Main(string[] args)
    {
        string equipamento; // string porque é um texto
        string marca;  // string porque é um texto
        string modelo;  // string porque é um texto
        int anodeaquisição; //int porque é um número inteiro
        double preço; // double porque é um número decimal ou inteiro
        long numerodepatrimônio; // long porque é um número inteiro grande
        bool equipamentofuncionando; // bool porque é verdadeiro ou falso

        Console.WriteLine("===================================");
        Console.WriteLine("CADASTRO DE EQUIPAMENTO");
        Console.WriteLine("===================================");
        Console.WriteLine();

        Console.Write("Nome do equipamento: ");
        equipamento = Console.ReadLine();

        Console.Write("Marca: ");
        marca = Console.ReadLine();

        Console.Write("Modelo: ");
        modelo = Console.ReadLine();

        Console.Write("Ano de aquisição: ");
        anodeaquisição = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        preço = double.Parse(Console.ReadLine());

        Console.Write("Número de patrimônio: ");
        numerodepatrimônio = long.Parse(Console.ReadLine());

        Console.Write("O equipamento está funcionando? (true/false): ");
        equipamentofuncionando = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("===================================");
        Console.WriteLine("DADOS DO EQUIPAMENTO");
        Console.WriteLine("===================================");
        Console.WriteLine();

        Console.WriteLine("Nome do equipamento: " + equipamento);
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Ano de aquisição: " + anodeaquisição);
        Console.WriteLine("Preço: R$ " + preço.ToString("F2"));
        Console.WriteLine("Número de patrimônio: " + numerodepatrimônio);
        Console.WriteLine("O equipamento está funcionando? " + equipamentofuncionando);

        Console.WriteLine("===================================");
        Console.WriteLine();

    }
}
