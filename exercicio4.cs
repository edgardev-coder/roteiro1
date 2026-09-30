using System.Globalization;

ContaBancaria conta1 = new ContaBancaria("Maria", 1001, 500.00);
ContaBancaria conta2 = new ContaBancaria("João", 1002, 100.00);

Console.WriteLine("=== Conta 1 ===");
conta1.ExibirSaldo();
conta1.Depositar(250.00);
conta1.Sacar(100.00);
conta1.Sacar(1000.00);
conta1.ExibirSaldo();

Console.WriteLine();

Console.WriteLine("=== Conta 2 ===");
conta2.ExibirSaldo();
conta2.Sacar(150.00);
conta2.Depositar(-20.00);
conta2.Depositar(50.00);
conta2.Sacar(150.00);
conta2.ExibirSaldo();

class ContaBancaria
{
    public string Titular { get; set; }
    public int NumeroConta { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(string titular, int numeroConta, double saldoInicial)
    {
        Titular = titular;
        NumeroConta = numeroConta;
        Saldo = saldoInicial < 0 ? 0 : saldoInicial;
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de depósito inválido.");
            return;
        }
        Saldo += valor;
        Console.WriteLine($"Depósito de {Formatar(valor)} realizado.");
    }

    public void Sacar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de saque inválido.");
            return;
        }
        if (valor > Saldo)
        {
            Console.WriteLine($"Saque de {Formatar(valor)} negado: saldo insuficiente.");
            return;
        }
        Saldo -= valor;
        Console.WriteLine($"Saque de {Formatar(valor)} realizado.");
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Titular: {Titular} | Conta: {NumeroConta} | Saldo: {Formatar(Saldo)}");
    }

    private static string Formatar(double v) => v.ToString("C", new CultureInfo("pt-BR"));
}
