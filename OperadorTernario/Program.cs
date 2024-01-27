Console.WriteLine(" ## Operador Ternário $$\n");
//O operador ternário utiliza 3 argumentos e avalia uma expressão booleana "?:"
//sintaxe --> condição? expressão1_se_true: expressão2_se_false
//Condição : qualquer expressão booleana
//Expressão1_se_true: expressão avaliada sea condição for verdadeira
//Expressão2_se_false: expressão avaliada se a condição for falsa

Console.WriteLine("Informe a temperatura: \n");

var temp = Convert.ToDouble(Console.ReadLine());
var resultado = temp > 27 ? "Quente" : "Normal";

Console.WriteLine($"O tempo está {resultado}");

Console.ReadKey();