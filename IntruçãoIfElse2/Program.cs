//Podemos usar intrução else if após a instrução if para avaliar mais de uma condição.
//As instruções else if somente serão executadas se a condição na instrução if for falsa
//Portanto ou a intrução if sera executada ou uma das instruções else if será executada, mas não ambas.
Console.WriteLine(" ## Instrução if-else-if ##\n");

Console.WriteLine("\nInforme a nota do aluno: \t");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Aluno Reprovado");
}
else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno em recuperação! ");
}
else if (nota >= 6 && nota <= 9)
{
    Console.WriteLine("Aluno aprovado! ");
}