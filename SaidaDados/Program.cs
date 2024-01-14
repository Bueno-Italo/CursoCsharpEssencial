Console.WriteLine("Saida de dados: Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.Write(nome);
Console.Write(idade);
Console.WriteLine();

//Escrever na mesma linha: "Maria tem  anos"
Console.Write(nome);
Console.Write("tem");
Console.Write(idade);
Console.Write("anos");
Console.WriteLine("--------Concatenação----------");

//Usar a concatenação: usando o operador o operador +
Console.WriteLine(nome + " tem " + idade + " anos ");
Console.Write(nome + " tem " + idade + " anos ");
Console.WriteLine("--------Interpolação----------");

//Usando a interpolação de strings: $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos");


