// Inferencia de tipos - palavra-chave VAR 
// int x = 0; ---------> Definição explicita ou direta do tipo de dados da variável x

// var x = 0; ---------> Definição implícita ou indireta do tipo de dados da variável x

using System.Diagnostics.CodeAnalysis;

Console.WriteLine(" ## Inferência Tipos (var) ##\n");

//Declarando as variáveis
var idade = 25;
var nome = "Italo";
var salario = 2500.00m;

//Imprimindo os resultados com interpolação $
Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

//Var limitações
var salario = null;
var titulo;
var salario, imposto, total;

//Não posso mudar o tipo apos inicialiar
var num = 10;
num = num + 20;
num = "Teste";

Console.ReadKey();
