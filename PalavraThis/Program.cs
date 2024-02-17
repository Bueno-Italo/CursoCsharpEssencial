Console.WriteLine("## \n This ##");

Teste t1 = new Teste(999);

public class Teste
{
    public Teste(int num1, int num2)

    {
        Console.WriteLine($"\n Construtor com dois parametros {num1} e {num2}")
    }

    public Teste(int num) : this(777, 888)
    {
        Console.WriteLine("\nConstrutor com um parametro" + num);
    }
}