﻿Console.WriteLine("##\nMétodos##");

MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao();
//minhaClasse.ExibirDataAtual();



Console.ReadKey();

class MinhaClasse 
{
    public void Saudacao()
    {
        Console.WriteLine("Bem-vindo");
        ExibirDataAtual();
    }
    public void ExibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortTimeString());
    }
}
