Console.WriteLine("## Estrutura Repetição 2 While ##\n");

int numero;
int contador = 1;

Console.WriteLine("\nDigite um numero maior que zero\t");
numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
    {

        //loop while
        Console.WriteLine($"\nTabuada do numero {numero} ##\n");
        while (contador < 11)
        {
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            contador++;
        }

    }
    else
    {
        Console.WriteLine("\nNumero deve ser maior que zero");
    }

Console.WriteLine("Fim do processamento...");

Console.ReadKey();