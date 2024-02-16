Console.WriteLine("##\nContrutor##");

public class Aluno
{
    //Construtor parametrizado usado para inicializar os mebros da classe
    public Aluno(string nome, string idade, string sexo, string aprovado)
    {
        nome = nome;
        idade = idade;
        sexo = sexo;
        aprovado = aprovado;
    }

    public string nome;
    public string idade;
    public string sexo;
    public string aprovado;
}