class Livro
{
    public string Titulo;
    public string Autor;
    public int NumerosPaginas;

    public Livro(string titulo, string autor, int numerosPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        if (numerosPaginas > 0)
        {
            NumerosPaginas = numerosPaginas;

        }
        else
        {
            Console.WriteLine("Você nao pode criar um livro com numeros de paginas negativas");
        }
    }

    public string GetTitulo()
    {
        return this.Titulo;
    }
    public string GetAutor()
    {
        return this.Autor;
    }
    public int GetNum()
    {
        return this.NumerosPaginas;
    }

    public override string ToString()
    {
        return $"Titulo: {this.Titulo}\nAutor: {this.Autor}\nQuantidade de paginas: {this.NumerosPaginas}";
    }

}
