using System;
using System.Collections.Generic;

public class Membro : Pessoa
{
    public DateTime DataDeInscricao { get; set; }
    public List<Livro> LivrosEmprestados { get; set; }

    public Membro()
    {
        LivrosEmprestados = new List<Livro>();
    }

    public void PegarLivroEmprestado(Livro livro)
    {
        LivrosEmprestados.Add(livro);
        livro.Emprestar(this);
    }

    public void DevolverLivro(Livro livro)
    {
        LivrosEmprestados.Remove(livro);
        livro.Devolver();
    }
}
