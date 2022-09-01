// See https://aka.ms/new-console-template for more information


// definição do método
void MeuMetodo()
{
    Console.WriteLine("C# é legal");
}

// Invocação do método
MeuMetodo();


string RetornaNome(string nome, string sobrenome, int idade = 44)
{
    return nome + " " + sobrenome + " tem " + idade + " anos ";
}

var nome = RetornaNome("leandro", "lopes");

Console.WriteLine(nome);


