
using System;

class Program
{
    static void Main()
    {
        
        string nome;
        int idade;
        string plano;
        double mensalidade;
        bool ativo;
        Console.WriteLine("============================");
        Console.WriteLine("CADASTRO DA ACADEMIA");
        Console.WriteLine("============================");

        Console.Write("Nome do aluno: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Plano da academia: ");
        plano = Console.ReadLine();

        Console.Write("Valor da mensalidade: ");
        mensalidade = Convert.ToDouble(Console.ReadLine());

        Console.Write("Matricula ativa? (true/false): ");
        ativo = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("============================");
        Console.WriteLine();
        Console.WriteLine("============================");
        Console.WriteLine("DADOS DA ACADEMIA");
        Console.WriteLine("============================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Plano: " + plano);
        Console.WriteLine("Mensalidade: R$ " + mensalidade);
        Console.WriteLine("Matricula ativa: " + ativo);
        Console.WriteLine("============================");
    }
}
