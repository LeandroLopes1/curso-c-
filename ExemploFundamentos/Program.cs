using ExemploFundamentos.Models;

Pessoa p = new Pessoa();
p.Nome = "João";
p.Idade = 20;

p.Apresentar();

Calculadora calc = new Calculadora();
calc.Somar(10, 20);
calc.Subtrair(10, 20);
calc.Multiplicar(10, 20);
calc.Dividir(20, 20);
calc.Potencia(2, 3);
