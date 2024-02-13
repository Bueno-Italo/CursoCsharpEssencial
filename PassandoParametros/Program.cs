Console.WriteLine("##\n Passando Parametros ##");

var aluno = new Aluno();

Console.WriteLine("Idade: ");
aluno.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("Sexo: ");
aluno.Sexo = Console.ReadLine();
Console.WriteLine("Aprovado (S)im (N)ão: ");
aluno.Aprovado = Console.ReadLine();

Curso curso = new();
curso.Resultado(aluno);

Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;    
    public string? Aprovado;
}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\nO aluno {aluno.Nome}, sexo {aluno.Sexo} com {aluno.Idade} anos");
        if (aluno.Aprovado == "S")
            Console.WriteLine("\nFoi Aprovado");
        else
            Console.WriteLine("\nFoi Reprovado");
    }
}