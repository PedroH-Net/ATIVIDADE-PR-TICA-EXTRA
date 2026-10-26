
using System;

/*
Nome do sistema:
Sistema de Cadastro de Alunos.

Problema que o sistema resolve:
Facilitar o cadastro de alunos.

Informações necessárias:
Nome, idade, cidade, curso, nota,
mensalidade, matricula ativa e faltas.

Variáveis:
string, int, double e bool.

Como o usuário interage:
Digitando os dados pelo teclado.

Como será a saída:
Os dados serao exibidos organizadamente.
*/

class Program
{
    static void Main()
    {
        string nome;
        int idade;
        string cidade;
        string curso;
        double nota;
        double mensalidade;
        bool matriculaAtiva;
        int faltas;

        
        Console.WriteLine("================================");
        Console.WriteLine(" SISTEMA DE CADASTRO DE ALUNOS");
        Console.WriteLine("================================");

        
        Console.Write("Nome do aluno: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Curso: ");
        curso = Console.ReadLine();

        Console.Write("Nota: ");
        nota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Mensalidade: ");
        mensalidade = Convert.ToDouble(Console.ReadLine());

        Console.Write("Matricula ativa? (true/false): ");
        matriculaAtiva = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Numero de faltas: ");
        faltas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("================================");

        Console.WriteLine();

        Console.WriteLine("================================");
        Console.WriteLine("       DADOS DO ALUNO");
        Console.WriteLine("================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Curso: " + curso);
        Console.WriteLine("Nota: " + nota);
        Console.WriteLine("Mensalidade: R$" + mensalidade);
        Console.WriteLine("Matricula ativa: " + matriculaAtiva);
        Console.WriteLine("Numero de faltas: " + faltas);
        Console.WriteLine("================================");
    }
}
