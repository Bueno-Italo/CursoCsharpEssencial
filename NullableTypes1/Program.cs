Console.WriteLine("## Nullable Types ##\n");

int? i = null;
double? d = null;
bool? z = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(z);

Console.ReadLine();

int? a = null;

if (a.HasValue)
{
    Console.WriteLine($"a = {a.Value}");
}
else
{
    Console.WriteLine("a não possui um valor ");
}

Console.ReadLine();
