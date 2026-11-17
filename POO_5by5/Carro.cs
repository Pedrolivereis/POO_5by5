using System.Threading.Channels;

public class Carro
{
    public string Fabricante;
    public string Modelo;
    public int AnoFabricacao;
    public int AnoModelo;
    public double ValorVenda;

    public void SetFabricante(string fabricante)
    {
        Fabricante = fabricante;
    }
    public void SetModelo(string modelo)
    {
        Modelo = modelo;
    }
    public void SetAnoFabricacao(int anoFabricacao)
    {
        AnoFabricacao = anoFabricacao;
    }
    public void SetAnoModelo(int anoModelo)
    {
       AnoModelo = anoModelo;
    }
    public void SetValorVenda(double valorVenda)
    {
        ValorVenda = valorVenda;
    }

    public string GetFabricante()
    {
        return Fabricante;
    }
    public string GetModelo()
    {
        return Modelo;
    }
    public int GetAnoFabricacao()
    {
        return AnoFabricacao;
    }
    public int GetAnoModelo()
    {
        return AnoModelo;
    }
    public double GetValorVenda()
    {
        return ValorVenda;
    }

    public void GetCalcularTempo()
    {
        if (2026 - AnoFabricacao > 20)
        {
            Console.WriteLine("Voce nao precisa mais pagar IPVA");
        }
        else
        {
            Console.WriteLine("Você ainda pecisa pagar IPVA");
        }
    }
    public override string ToString()
    {
        return $"Fabricante: {this.Fabricante}\nModelo: {this.Modelo}" +
                $"AnoFabricacao: {this.AnoFabricacao}\nAnoModelo: {AnoModelo}" +
                $"ValorVenda: {ValorVenda}";
    }
}