using System;
using System.Collections.Generic;
using ProjetoBiblioteca.Models;

public class Autor : Pessoa
{
    public string Biografia { get; set; }
    public List<Livro> ListaDeLivros { get; set; }

    public Autor()
    {
        ListaDeLivros = new List<Livro>();
    }

    public void AdicionarLivro(Livro livro)
    {
        ListaDeLivros.Add(livro);
    }

    public void RemoverLivro(Livro livro)
    {
        ListaDeLivros.Remove(livro);
    }
}
