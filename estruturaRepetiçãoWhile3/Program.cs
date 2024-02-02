/*A intrução break pode ser usada para encerrar uma instrução switch
ou um loop (while, for, if, etc.) */

Console.WriteLine("## Intrução While 3 ##\n");

while(true)
{
    Console.WriteLine("\nInforme um numero inteiro: (para sair tecle 999)");

    int numero = Convert.ToInt32(Console.ReadLine());
    
    if (numero == 999)
    {
        break;
    }
    if (numero%2 ==0)
    {
        Console.WriteLine($"{numero} é PAR");
    }
    else
    {
        Console.WriteLine($"{numero} é IMPAR");
    }

    Console.WriteLine("\nFim do processamento...");
    Console.ReadKey();


}
