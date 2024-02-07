//Executa um bloco de intruções repetidamente até que a condição retorne false
Console.WriteLine("##\nIntrução For 1");

//Criar um programa usando o lação for para exibir a tabuada de multiplicação de numeros inteiros
int resultado, numero;

Console.WriteLine("Informe o número inteiro : \t");
numero = Convert.ToInt32(Console.ReadLine());

for (int = 1; i <= 10; i++)
{
    resultado = numero * i;
    Console.WriteLine(numero + " X " + i + " = " + resultado);
}
Console.WriteLine("Fim do processamento...");
Console.ReadKey();
