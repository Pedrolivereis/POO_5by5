public class Pessoa
{
    public string Nome;
    public int Idade;
    public char Sexo;


    public Pessoa(string nome, int idade, char sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }


    public void SetNome()
    {
        Console.WriteLine("Informe seu nome: ");
        this.Nome = Console.ReadLine();
    }

    public string GetNome()
    {
        return this.Nome;
    }


    public override string ToString()
    {
        return "Nome: " + Nome + "\nIdade: " + Idade + "\nSexo: " + Sexo;
    }
}