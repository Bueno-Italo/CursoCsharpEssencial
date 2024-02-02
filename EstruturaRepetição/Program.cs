/* As estruturas de repetição são usadas para repetir intruções ou blocos de código, 
a decisão de repetiro o código é baseada na avaliação de uma expressão lógica. Se a 
expressão for verdadeira, o código é executado. Uma estrutura de repetição permite
especificar que uma ação seja repetida varias vezes, depedendo do valor da condição.*/


Console.WriteLine("##Estrutura de Repetição##\n");

        int i = 1;

    //Declarando Label
    repetir:

        Console.WriteLine($"i= {i}");

        i++;

        if (1 <= 10)
            goto repetir;

Console.WriteLine("Fim do processamento");