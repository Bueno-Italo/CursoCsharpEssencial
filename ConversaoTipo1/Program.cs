Console.WriteLine("## Conversão de tipos 1 ##\n");

int valorInt = 10;
double valorDouble = 5.354;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToString(valorDouble));

int varInt = 100000;
Console.WriteLine(Convert.ToByte(varInt));

Console.ReadLine();
