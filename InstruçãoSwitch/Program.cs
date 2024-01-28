//O bloco switch é uma estrutura de condição que define o código a ser executado com base em uma comparação de valores
//A instrução switch pode ser usada para substituir a instrução if-else-if.
Console.WriteLine(" ## Estrutura Switch ## \n");
int compra = 600;
Console.WriteLine("Valor da compra R$ 600,00");
Console.WriteLine("Informe o numero de parcelas (1 a 3)");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1: Console.WriteLine($"\nPrestação R$ {compra/numeroParcelas}"); 
        break;

    case 2: Console.WriteLine($"\nPrestações R$ {compra / numeroParcelas}");
        break;
    
    case 3: Console.WriteLine($"\nPrestações R$ {compra / numeroParcelas}");
        break;

    default: Console.WriteLine("\nValor invalido, informe 1, 2 ou 3"); 
        break;
}

Console.WriteLine("Fim do processamento...");


