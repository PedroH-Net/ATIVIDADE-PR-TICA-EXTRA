
using System;


/*
Informacoes: nome, idade, cargo, salario e
situacao do funcionario.

Variaveis: string, int, double e bool.

Entrada: dados digitados pelo usuario.
Saida: exibicao dos dados cadastrados.
*/


class Program
{
    static void Main()
    {
        
        string nome;
        int idade;
        string cargo;
        double salario;
        bool ativo;

        Console.WriteLine("===================================");
        Console.WriteLine("CADASTRO DE FUNCIONÁRIO");
        Console.WriteLine("===================================");


        Console.Write("Nome do funcionario: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Cargo: ");
        cargo = Console.ReadLine();

        Console.Write("Salário: ");
        salario = Convert.ToDouble(Console.ReadLine());

        Console.Write("O funcionario esta ativo? (true/false): ");
        ativo = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("===================================");



        Console.WriteLine();
        Console.WriteLine("===================================");
        Console.WriteLine("DADOS DO FUNCIONARIO");
        Console.WriteLine("===================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Salario: R$ " + salario);
        Console.WriteLine("Ativo: " + ativo);
        Console.WriteLine("===================================");
    }
}
