// Constantes são valores imutáveis que são conhecidos em tempo de compilação e não mudam durante a vida útil do programa
// As constantes são declaradas usando modificador const e devem ser inicializadas na sua delaração

Console.WriteLine(" ## Constantes ##\n");

const int ANO = 12;
const int MES = 30, SEMANA = 7, QUINZENA = 15;

const int MESES_ANO = 12;
const int DIAS_ANO = 365;

const float DIAS_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;

Console.WriteLine(DIAS_POR_MES);

Console.ReadKey();

Console.WriteLine("----------Calculando de um circulo----------");

//Caluculo da area e perímetro do circulo

double raio, perimetro, area;

const double PI = 3.14;

Console.WriteLine("Informe o raio do circulo");
raio = double.Parse(Console.ReadLine());

perimetro = 2 * PI * raio;
area = PI * raio * raio;

Console.WriteLine($"Perimetro = {perimetro}");
Console.WriteLine($"Área = {area}");

Console.ReadKey();