class Program
{
    static void Main()
    {
        string nome, equipamento;
        int idade, quantidadedias;
        double valordalocação;
        long código;
        bool equipamentodisponível;

        Console.WriteLine("============================");
        Console.WriteLine("SISTEMA DE LOCAÇÃO");
        Console.WriteLine("============================");
        Console.WriteLine();



        Console.Write("Qual seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Qual sua idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Qual sua equipamento: ");
        equipamento = Console.ReadLine();

        Console.Write("Quantidade de dias: ");
        quantidadedias = int.Parse(Console.ReadLine());

        Console.Write("Código do equipamento: ");
        código = long.Parse(Console.ReadLine());

        Console.Write("Valor da locação: ");
        valordalocação = double.Parse(Console.ReadLine());

        Console.Write("Equipamento disponível (true/false): ");
        equipamentodisponível = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("============================");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("============================");
        Console.WriteLine("DADOS DO PEDIDO  ");
        Console.WriteLine("============================");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Qual sua equipamento: " + equipamento);
        Console.WriteLine("Quantidade: " + quantidadedias + " dias");
        Console.WriteLine("Código: " + código);
        Console.WriteLine("Valor da locação:  R$" + valordalocação);
        Console.WriteLine("Equipamento disponível? (true/false): " + equipamentodisponível);

        Console.WriteLine();
        Console.WriteLine("============================");
        Console.WriteLine();


    }
}
