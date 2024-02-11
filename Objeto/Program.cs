/*Objeto é uma instancia de uma classe, criado pelo operador new, e, todos os membros
da classe podem ser acessador através do objeto*/

Console.WriteLine("##\nObjeto##");

Pessoa p1 = new();
p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "Feminino";

Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");
Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string sexo;
}