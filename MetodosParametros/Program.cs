/*Parâmetro é um valor passado para o método, os métodos 
podem receber um ou mais parâmetros que são especificados
dentro dos parênteses, após a definição do nome do método,
e são separados por vírgulas*/
Console.WriteLine("##\n Métodos com Parâmetros ##");

MinhaClasse minhaclasse = new MinhaClasse();
var nomeCliente = "Maria";

var dataAtual = DateTime.Now.ToShortDateString();

minhaclasse.Saudacao(nomeCliente, dataAtual);

Console.ReadKey();

public class MinhaClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLinenome);
        Console.WriteLine(data);
    }
}
