Livro CriarLivro()
{
    Console.WriteLine("Titulo do livro:");
    string titulo = Console.ReadLine();

    Console.WriteLine("Autor do livro: ");
    string autor = Console.ReadLine();

    Console.WriteLine("Quantas paginas: ");
    int numeros = int.Parse(Console.ReadLine());

    Livro l1 = new(titulo, autor, numeros);

    l1.GetAutor();
    l1.GetTitulo();
    l1.GetNum();

    return l1;
}
CriarLivro();






ContaBancaria CriarConta()
{
    Console.WriteLine("Digite o nome do Titular: ");
    string titular = Console.ReadLine();

    double saldo = 0;

    ContaBancaria c1 = new();

    c1.CadastrarTitular(titular);
    c1.CadastarSaldo(saldo);
    c1.ExibirInfo(titular, saldo);

    return c1;

}
CriarConta();


Carro CadasrarCarro()
{
    Console.WriteLine("Informe o fabricante: ");
    string fab = Console.ReadLine();
    Console.WriteLine("Informe o modelo: ");
    string mod = Console.ReadLine();
    Console.WriteLine("Informe o ano de fabricaçao: ");
    int anofab = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o ano do modelo: ");
    int anoMod = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o valor de venda: ");
    double valorVenda = double.Parse(Console.ReadLine());

    Carro c = new();

    c.SetFabricante(fab);
    c.SetModelo(mod);
    c.SetAnoFabricacao(anofab);
    c.SetAnoModelo(anoMod);
    c.SetValorVenda(valorVenda);
    c.SetAnoFabricacao(anofab);

    return c;
}

Carro[] carros = new Carro[4];

var carro = CadasrarCarro();
carros[0] = carro;
carro = CadasrarCarro();
carros[1] = carro;
carro = CadasrarCarro();
carros[2] = carro;
carro = CadasrarCarro();
carros[3] = carro;
carro = CadasrarCarro();
carros[4] = carro;

void MostrarCarros()
{
    for (int i = 0; i < carros.Length; i++)
    {
        Console.WriteLine(carros[i].ToString());
    }
}
MostrarCarros();
