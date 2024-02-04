Console.WriteLine("## Estrutura While ##\n");

var i = 1;
do
{
    Console.WriteLine($"i = {i}");
    i++;

    if (i > 7)
        break;
}
while (i <= 10);

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

Console.WriteLine("-------Segunda Hipótese-------");

int x = 0;

do
{
    int y = 0;
    do
    {
        Console.Write($"({x}, {y}) ");
        y++;
    }
    while (y < 5);
    x++;
    Console.WriteLine();
}
while (x < 5);

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();