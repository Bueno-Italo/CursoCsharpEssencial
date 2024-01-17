Console.WriteLine("\n ## Operadores Aritiméticos ##");

Console.WriteLine("Infomrme o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Infomrme o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nRaiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"\nPotência de x elevado a y = {Math.Pow(x,y)}");
Console.WriteLine($"\nValor mínimo entre x e y = {Math.Min(x,y)}");
Console.WriteLine($"\nValor máximo entre x e y = {Math.Max(x,y)}");

