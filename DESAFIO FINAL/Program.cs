
/*
Cadastrar os dados de tres alunos:
nome, idade, cidade, altura, curso e estudante ativo.

Analise:
a) Foram necessarias varias variaveis para cada aluno.
b) Com 10 alunos, seriam muitas variaveis.
c) Com 100 alunos, o codigo ficaria muito maior.
d) O codigo ficaria mais dificil de entender.
e) Alterar informacoes seria mais trabalhoso.
f) Os dados ficariam separados em varias variaveis.
g) O problema seria a repeticao e a desorganizacao do codigo.

Proposta:
A estrutura Aluno permitiria agrupar os dados de cada
estudante, facilitando o cadastro e a organizacao
de varios alunos.

O que aprendi:
A POO ajuda a organizar o codigo e facilita o trabalho
quando precisamos cadastrar muitos alunos.
*/


using System;

class Program
{
    static void Main()
    {

        // Variaveis do primeiro aluno
        string nome1, cidade1, curso1;
        int idade1;
        double altura1;
        bool ativo1;

        // Variaveis do segundo aluno
        string nome2, cidade2, curso2;
        int idade2;
        double altura2;
        bool ativo2;

        // Variaveis do terceiro aluno
        string nome3, cidade3, curso3;
        int idade3;
        double altura3;
        bool ativo3;

        // Cadastro do primeiro aluno
        Console.WriteLine("============================");
        Console.WriteLine("PRIMEIRO ALUNO");
        Console.WriteLine("============================");
        Console.Write("Nome: ");
        nome1 = Console.ReadLine();

        Console.Write("Idade: ");
        idade1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade1 = Console.ReadLine();

        Console.Write("Altura: ");
        altura1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Curso: ");
        curso1 = Console.ReadLine();

        Console.Write("Estudante ativo? (true/false): ");
        ativo1 = Convert.ToBoolean(Console.ReadLine());

        // Cadastro do segundo aluno
        Console.WriteLine("============================");
        Console.WriteLine("SEGUNDO ALUNO");
        Console.WriteLine("============================");

        Console.Write("Nome: ");
        nome2 = Console.ReadLine();

        Console.Write("Idade: ");
        idade2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade2 = Console.ReadLine();

        Console.Write("Altura: ");
        altura2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Curso: ");
        curso2 = Console.ReadLine();

        Console.Write("Estudante ativo? (true/false): ");
        ativo2 = Convert.ToBoolean(Console.ReadLine());

        // Cadastro do terceiro aluno
        Console.WriteLine("============================");
        Console.WriteLine("TERCEIRO ALUNO");
        Console.WriteLine("============================");

        Console.Write("Nome: ");
        nome3 = Console.ReadLine();

        Console.Write("Idade: ");
        idade3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade3 = Console.ReadLine();

        Console.Write("Altura: ");
        altura3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Curso: ");
        curso3 = Console.ReadLine();

        Console.Write("Estudante ativo? (true/false): ");
        ativo3 = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("============================");
        Console.WriteLine();

        // Exibicao dos cadastros
        Console.WriteLine("============================");
        Console.WriteLine("ALUNOS CADASTRADOS");
        Console.WriteLine("============================");

        Console.WriteLine("Aluno 1:");
        Console.WriteLine("Nome: " + nome1);
        Console.WriteLine("Idade: " + idade1);
        Console.WriteLine("Cidade: " + cidade1);
        Console.WriteLine("Altura: " + altura1);
        Console.WriteLine("Curso: " + curso1);
        Console.WriteLine("Ativo: " + ativo1);
        Console.WriteLine("============================");
        Console.WriteLine("============================");

        Console.WriteLine("Aluno 2:");
        Console.WriteLine("Nome: " + nome2);
        Console.WriteLine("Idade: " + idade2);
        Console.WriteLine("Cidade: " + cidade2);
        Console.WriteLine("Altura: " + altura2);
        Console.WriteLine("Curso: " + curso2);
        Console.WriteLine("Ativo: " + ativo2);
        Console.WriteLine("============================");
        Console.WriteLine("============================");

        Console.WriteLine("Aluno 3:");
        Console.WriteLine("Nome: " + nome3);
        Console.WriteLine("Idade: " + idade3);
        Console.WriteLine("Cidade: " + cidade3);
        Console.WriteLine("Altura: " + altura3);
        Console.WriteLine("Curso: " + curso3);
        Console.WriteLine("Ativo: " + ativo3);
        Console.WriteLine("============================");
    }
}

