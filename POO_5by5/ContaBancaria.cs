public class ContaBancaria
{
    public string Titular;
    public double Saldo;


    public void CadastrarTitular(string titular)
    {

        Titular = titular;
    }

    public void CadastarSaldo(double saldo)
    {
        Saldo = saldo;
    }

    public void Depositar(double depositar)
    {
        Console.WriteLine("Quanto deseja depositar: ");
        depositar = double.Parse(Console.ReadLine());
        if (depositar > 0)
        {
            Saldo += depositar;
        }
        Console.WriteLine("Nao é possivel depositar um numero negativo");

        
    }

    public void Sacar(double sacar)
    {
        Console.WriteLine("Quanto deseja sacar: ");
        if (Saldo < sacar)
        {
            Console.WriteLine($"Voce nao pode sacar R${sacar} pois você tem {Saldo}");
        }
        Saldo -= sacar;
    }

    public void ExibirInfo(string titular,double saldo)
    {
        Console.WriteLine($"O titular da conta é {titular}");
        Console.WriteLine($"O seu saldo é de R${saldo:f2}");
    }

    public override string ToString()
    {
        return $"Titular: {this.Titular}\nSaldo: {this.Saldo:f2}";
    }
}
