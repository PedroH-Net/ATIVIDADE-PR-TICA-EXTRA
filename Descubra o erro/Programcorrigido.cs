
using System;

class Programcorrigido
{
    static void Main()
    {
        
        string nome;
        int idade;
        double salario;

        //Mudado de WriteLine para Write e adicionado espaço dentro da caixa do Console.Write.

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());//Convert.ToInt32(Console.ReadLine()) adicionado no lugar de só Console.ReadLine()

        Console.Write("Digite seu salario: ");
        salario = Convert.ToDouble(Console.ReadLine());

        // nome do aluno alterado para o nome da variavel string nome
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Salario: " + salario);
    }
}


/*
RELATORIO DE CORRECOES

Problema: Erro no tipo de dado da idade.
Causa: O texto nao foi convertido para inteiro.
Correcao: Utilizado Convert.ToInt32().

Problema: Nome de variavel incorreto.
Causa: A variavel aluno nao existia.
Correcao: Substituido por nome.

Problema: Erro de sintaxe.
Causa: Faltava ponto e virgula.
Correcao: Adicionado o ponto e virgula.

Problema: Organizacao da entrada.
Causa: A mensagem quebrava a linha.
Correcao: Utilizado Console.Write().
*/

