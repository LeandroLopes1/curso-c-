using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine($"A soma de {a} + {b} = {a + b}");
        }

        public void Subtrair(int a, int b)
        {
            Console.WriteLine($"A subtração de {a} - {b} = {a - b}");
        }

        public void Multiplicar(int a, int b)
        {
            Console.WriteLine($"A multiplicação de {a} * {b} = {a * b}");
        }

        public void Dividir(int a, int b)
        {
            Console.WriteLine($"A divisão de {a} / {b} = {a / b}");
        }

        public void Potencia(int a, int b)
        {
            Console.WriteLine($"A potência de {a} ^ {b} = {Math.Pow(a, b)}");
        }
    }
}