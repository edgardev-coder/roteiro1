using System.Globalization;

Produto p1 = new Produto("Notebook", 3500.00, 2);
Produto p2 = new Produto("Mouse", 50.00, 10);
Produto p3 = new Produto("Teclado", 120.00, 5);

Produto[] produtos = { p1, p2, p3 };

foreach (Produto p in produtos)
{
    p.ExibirDados();
    Console.WriteLine($"Valor total: {p.CalcularValorTotal().ToString("C", new CultureInfo("pt-BR"))}");
    Console.WriteLine();
}

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preco.ToString("C", new CultureInfo("pt-BR"))}");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }

    public double CalcularValorTotal()
    {
        return Preco * Quantidade;
    }
}
