using System;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': operacao.resultado= soma(operacao);break;
                case '-': operacao.resultado = subtracao(operacao);break;
                case '*': operacao.resultado = multiplicacao(operacao);break;
                case '/': operacao.resultado = divisao(operacao);break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        //Alterado de int para 'decimal' para suportar resultados corretos em diversos cenários
        public decimal soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public decimal subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public decimal multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        
        //Incluido a operaçao de divisao, com excessao caso o divisor seja 0.
        public decimal divisao(Operacoes operacao)
        {
            if (operacao.valorB == 0)
            {
                throw new DivideByZeroException("Divisão por 0 não é permitida");
            }
            return operacao.valorA / operacao.valorB;
        }
    }
    }
