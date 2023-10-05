using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Autor autor1 = new Autor
        {
            Nome = "Autor 1",
            DataNascimento = new DateTime(1980, 1, 1),
            Biografia = "Uma breve biografia do Autor 1."
        };

        Autor autor2 = new Autor
        {
            Nome = "Autor 2",
            DataNascimento = new DateTime(1990, 2, 2),
            Biografia = "Uma breve biografia do Autor 2."
        };

        Membro membro1 = new Membro
        {
            Nome = "Membro 1",
            DataNascimento = new DateTime(2000, 3, 3),
            DataDeInscricao = DateTime.Now
        };

        Membro membro2 = new Membro
        {
            Nome = "Membro 2",
            DataNascimento = new DateTime(1995, 4, 4),
            DataDeInscricao = DateTime.Now
        };

        GeneroLiterario genero1 = new GeneroLiterario
        {
            Nome = "Ficção Científica",
            Descricao = "Descrição da Ficção Científica."
        };

        GeneroLiterario genero2 = new GeneroLiterario
        {
            Nome = "Romance",
            Descricao = "Descrição do Romance."
        };

        Livro livro1 = new Livro
        {
            Titulo = "Livro 1",
            Autor = autor1,
            Genero = genero1,
            DataPublicacao = new DateTime(2020, 5, 5)
        };

        Livro livro2 = new Livro
        {
            Titulo = "Livro 2",
            Autor = autor2,
            Genero = genero2,
            DataPublicacao = new DateTime(2019, 6, 6)
        };

        membro1.PegarLivroEmprestado(livro1);
        membro2.PegarLivroEmprestado(livro2);

        membro1.DevolverLivro(livro1);

        Console.WriteLine("Livros emprestados por Membro 1:");
        foreach (var livro in membro1.LivrosEmprestados)
        {
            Console.WriteLine($"Título: {livro.Titulo}");
        }

        Console.WriteLine("\nLivros emprestados por Membro 2:");
        foreach (var livro in membro2.LivrosEmprestados)
        {
            Console.WriteLine($"Título: {livro.Titulo}");
        }

        Console.WriteLine("\nLivros de Autor 1:");
        foreach (var livro in autor1.ListaDeLivros)
        {
            Console.WriteLine($"Título: {livro.Titulo}");
        }
    }
}
