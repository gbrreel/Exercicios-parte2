using System;
using System.Globalization;

namespace ExerciciosParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicios 1");
            Console.WriteLine("Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.");
            Console.WriteLine("");
            
            int N = int.Parse(Console.ReadLine());
            
            if (N < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO E NEGATIVO");
            }
            
            Console.WriteLine("");
            Console.WriteLine("Exercicios 2");
            Console.WriteLine("Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.");
            Console.WriteLine("");
            
            int Numero = int.Parse(Console.ReadLine());
            
            if (Numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            
            Console.WriteLine("");
            Console.WriteLine("Exercicios 3");
            Console.WriteLine("Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem Sao Multiplos ou Nao sao Multiplos, indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.");
            Console.WriteLine("");
            
            string[] valores = Console.ReadLine().Split(' ');
            
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            
            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }
            
            Console.WriteLine("");
            Console.WriteLine("Exercicios 4");
            Console.WriteLine("Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.");
            Console.WriteLine("");
            
            Console.WriteLine("Digite o horario inicio e o horario final do jogo:");
            string[] horarios = Console.ReadLine().Split(' ');
            
            int horarioInicial = int.Parse(horarios[0]);
            int horarioFinal = int.Parse(horarios[1]);
            
            int duracao;
            if (horarioInicial < horarioFinal)
            {
                duracao = horarioFinal - horarioInicial;
            }
            else
            {
                duracao = 24 - horarioInicial + horarioFinal;
            }
            
            Console.WriteLine("O jogo dirou " + duracao + "hora(s)");      
            
            Console.WriteLine("");
            Console.WriteLine("Exercicios 5");
            Console.WriteLine("Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.");
            Console.WriteLine("");
            
            Console.WriteLine("+--------+------------------+---------+");
            Console.WriteLine("| CÓDIGO | ESPECIFICAÇÃO    | PREÇO   |");
            Console.WriteLine("+--------+------------------+---------+");
            Console.WriteLine("|   1    | Cachorro Quente  | R$ 4.00 |");
            Console.WriteLine("|   2    | X-Salada         | R$ 4.50 |");
            Console.WriteLine("|   3    | X-Bacon          | R$ 5.00 |");
            Console.WriteLine("|   4    | Torrada Simples  | R$ 2.00 |");
            Console.WriteLine("|   5    | Refrigerante     | R$ 1.50 |");
            Console.WriteLine("+--------+------------------+---------+");
            Console.WriteLine("");

            Console.WriteLine("Digite o codigo e a quantidade do produto:");
            string[] valor = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valor[0]);
            int quantidade = int.Parse(valor[1]);

            double total;
            if (codigo == 1) {
                total = quantidade * 4.0;
            }
            else if (codigo == 2) {
                total = quantidade * 4.5;
            }
            else if (codigo == 3) {
                total = quantidade * 5.0;
            }
            else if (codigo == 4) {
                total = quantidade * 2.0;
            }
            else {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
};

