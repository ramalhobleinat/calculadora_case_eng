using System;
namespace Calculadora
{
    public class Operacoes
    {
        // Alterado o tipo de dado das propriedades para decimal garantindo resultado certo para operações grandes
        public decimal valorA {get;set;}
        public char operador { get; set; }
        public decimal valorB { get; set; }
        public decimal resultado { get; set; }

    }
}
