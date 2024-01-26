Console.WriteLine(" ## Operadores relacionais ## \n");
//== (igualdade)
//> (maior que)
//< (menor que)
//>= (maior ou igual)
//<= (menor ou igual)
//!= (nao igual ou diferente)
string a = "Curso";
string b = "curso";

//Interpolação de string
Console.WriteLine($"Valor de a {a}");
Console.WriteLine($"Valor de b {b}");

Console.WriteLine(a == b);
Console.WriteLine(a.Equals(b));



Console.ReadKey();