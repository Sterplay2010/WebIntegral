namespace Banco;

public class CuentaBancaria
{
    public string NombreTitular { get; set; }
    public double SaldoCuenta { get; set; }
    public string NumeroCuenta { get; set; }
    public string Nip { get; set; }

    public CuentaBancaria(string nombre, double saldo, string numero, string nip) =>
        (NombreTitular, SaldoCuenta, NumeroCuenta, Nip) = (nombre, saldo, numero, nip);

    public double depositar(double saldo)
    {
        return (SaldoCuenta += saldo);
    }

    public double retirar(double saldo)
    {
        return (SaldoCuenta -= saldo);
    }

    public double transferir(CuentaBancaria UserTwo, double saldo)
    {
        SaldoCuenta -= saldo;
        UserTwo.SaldoCuenta += saldo;
        return SaldoCuenta;
    }

    public void mensaje(String mensaje)
    {
        Console.WriteLine($"{mensaje}");
    }
} 