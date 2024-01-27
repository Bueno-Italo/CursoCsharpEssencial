//IF seleciona um bloco ou uma instrução para execução com base no valor de uma expressão booleana
//Usamos a intrução if para especificar um bloco de código que devera ser executado, se uma condição for verdadeira
Console.WriteLine(" ## Instrução if ##\n");

Console.WriteLine("Cliente especial (S/N)");
var resposta = Console.ReadLine();

if ( resposta == "S")
{
    Console.WriteLine("Desconto de 10%");
}
Console.WriteLine("Fim do processamento");
Console.ReadKey();

//Segunda Hipótese

Console.WriteLine("Clinete especial (Treu/False)");
var resposta1 = Convert.ToBoolean(Console.ReadLine());
if ( resposta1 == true)
{
    Console.WriteLine("Desconto de 10%");
}
Console.WriteLine("Fim do processamento");
Console.ReadKey();

//Comparar se x é maior, menor ou igual a y
Console.Write("Infome o valor de x: \t");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de y: \t");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine(" x é maior que y");
}
if (x < y)
{
    Console.WriteLine(" x é menor que y");
}
if ( x == y)
{
    Console.WriteLine(" x é igual a y");
}
Console.ReadKey();