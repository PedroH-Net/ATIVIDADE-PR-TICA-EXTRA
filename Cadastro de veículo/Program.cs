class Program
{
    static void Main()
    {
        string marca;
        string modelo;
        int ano;
        double preço;
        char inicialdamarca;
        bool veículodisponívelparavenda;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("CADASTRO DE VEÍCULO");
        Console.WriteLine("----------------------------------");
        Console.WriteLine();

        Console.Write("Marca: ");
        marca = Console.ReadLine();

        Console.Write("Modelo: ");
        modelo = Console.ReadLine();

        Console.Write("Ano: ");
        ano = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        preço = double.Parse(Console.ReadLine());

        Console.Write("Veículo disponível para venda? (true/false): ");
        veículodisponívelparavenda = bool.Parse(Console.ReadLine());

        inicialdamarca = marca[0];

        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("DADOS DO VEÍCULO");
        Console.WriteLine("----------------------------------");
        Console.WriteLine();
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Ano: " + ano);
        Console.WriteLine("Preço: R$ " + preço);
        Console.WriteLine("Inicial da marca: " + inicialdamarca);
        Console.WriteLine("Veículo disponível para venda? " + veículodisponívelparavenda);
        Console.WriteLine("----------------------------------");
    }
}
