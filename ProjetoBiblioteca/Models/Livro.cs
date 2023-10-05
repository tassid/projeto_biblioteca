using ProjetoBiblioteca.Models;

public class Livro : IEmprestavel
{
    public int ID { get; set; }
    public string Titulo { get; set; }
    public Autor Autor { get; set; }
    public GeneroLiterario Genero { get; set; }
    public DateTime DataPublicacao { get; set; }
    public Membro EmprestadoPara { get; set; }

    public Livro()
    {
        Autor = new Autor();
        Genero = new GeneroLiterario();
    }

    public void Emprestar(Membro membro)
    {
        EmprestadoPara = membro;
    }

    public void Devolver()
    {
        EmprestadoPara = null;
    }
}
