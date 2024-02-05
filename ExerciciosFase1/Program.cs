
Console.WriteLine("## Exercícios ##/n");

Console.WriteLine("Digite sua idade: ");
Console.ReadLine();
int idade = 30;
Console.WriteLine("Sua idade é: " + idade);

Console.WriteLine("-------------------------");

Console.WriteLine("Pressione a tecla ENTER!");
Console.ReadLine();

Console.WriteLine("Qual é o seu nome? ");
Console.ReadLine();
string nome = "italo";
Console.WriteLine("Seja bem vindo " + nome);

Console.WriteLine("-------------------------");

DateTime data = new DateTime(05 / 03 / 1993);
Console.WriteLine(data);

Console.WriteLine("------ExerciciosV2------");

{
    // Leitura dos dados de entrada
    Console.WriteLine("Informe o tempo gasto na viagem (em horas):");
    int tempoViagem = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe a velocidade média durante a viagem (em km/h):");
    int velocidadeMedia = int.Parse(Console.ReadLine());

    // Chamada da função para calcular a quantidade de litros necessária
    double litrosNecessarios = CalcularLitrosNecessarios(tempoViagem, velocidadeMedia);

    // Exibição do resultado com três casas decimais após o ponto
    Console.WriteLine($"Quantidade de litros necessária: {litrosNecessarios:F3}");
}

// Função para calcular a quantidade de litros necessária
static double CalcularLitrosNecessarios(int tempoViagem, int velocidadeMedia)
{
    // Distância = tempo * velocidade
    double distanciaPercorrida = tempoViagem * velocidadeMedia;

    // Quantidade de litros = distância / consumo
    double litrosNecessarios = distanciaPercorrida / 12.0;

    return litrosNecessarios;
}
