//A instrução if-else é composta por dois blocos de intruções: o bloco if e o bloco de intruções else
Console.WriteLine(" ## Instrução if-else ##\n");

Console.WriteLine("Informe a nota do aluno: ");
var nota = Convert.ToInt32(Console.ReadLine());

if (nota > 5)
{
    Console.WriteLine("Aluno APROVADO");
}
else
{
    Console.WriteLine("Aluno REPROVADO");
}
Console.WriteLine("Fim do processamento...");
Console.ReadKey();

//Comparar se x é maior, menor ou igual a y
Console.WriteLine("Informe o valor de x: ");
var x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y: ");
var y = Convert.ToInt32(Console.ReadLine());

if(x > y)
{
    Console.WriteLine("x é maior que y!");
}
else
{
    if(x < y)
    {
        Console.WriteLine("x é menor que y!");
    }
    else
    {
        Console.WriteLine("x é igual a y!");
    }
}
Console.WriteLine("Fim do processamento...");
Console.ReadKey();