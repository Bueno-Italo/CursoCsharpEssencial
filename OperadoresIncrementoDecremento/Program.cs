
Console.WriteLine(" ## Operadores Incremento e Decremento ## \n");

int x = 0;
//Imprimindo com interpolação de string
Console.WriteLine($" x = {x}");

//Pós-decremento -> primeiro resolve e depois decrementa
int resultado1 = x-- + 10;

Console.WriteLine($"pós-decremento == {resultado1}");
Console.WriteLine($"valor de x == {x}\n");

//Pré-incremento -> primeiro decrementa e depois resolve
int y = 0;
Console.WriteLine($"y = {y}") /
int resultado1 = --y + 10;

Console.WriteLine($"pré-decremento == {resultado1}");
Console.WriteLine($"valor de y == {y}\n");

Console.ReadKey();