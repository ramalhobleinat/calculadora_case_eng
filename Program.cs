using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            Stack<decimal> pilhaResultados = new Stack<decimal>();

            // filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' }); // Esse calculo nao faz parte da saída esperada e poderia ser considerado desvio do que foi solicitado
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implementado o calculo de divisao

            Calculadora calculadora = new Calculadora();

            //Adiciona esse print para que o console fique mais intuitivo todas as operaçoes que serão realizadas
            Console.WriteLine("\nOperações que serão realizadas:");
                foreach (var operacao in filaOperacoes)
                {
                    Console.WriteLine("{0} {1} {2}", operacao.valorA, operacao.operador, operacao.valorB);
                }

            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue(); // Usando Dequeue() ao invés de Peek(), essa troca garante que todas as operaçoes sejam processadas e evita loops infinitos 

                // Evidencia qual a operação que esta sendo processada
                Console.WriteLine("\nOperação atual:");

                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
                
                //Adiciona cada resultado na pilha
                pilhaResultados.Push(operacao.resultado);
                ImprimirFila(filaOperacoes);
            }

        //Imprime a pilha de resultados
        Console.WriteLine("\nPilha de resultados:");
        foreach (var resultado in pilhaResultados)
        {
            Console.WriteLine(resultado);
        }
        }
    
    static void ImprimirFila(Queue<Operacoes> fila)
{
    Console.WriteLine("\nOperações restantes na fila:");

    //  Imprime essa mensagem caso a fila estiver vazia (ou nula)
    if (fila == null || fila.Count == 0)
    {
        Console.WriteLine("Não há operações restantes na fila.");
        return;
    }

    // Percorre a fila para ler, nao remove os itens
    foreach (var operacao in fila)
    {
        // Mostra os valores
        Console.WriteLine("{0} {1} {2}", operacao.valorA, operacao.operador, operacao.valorB);
    }
}
        
    }
}
