using System.Globalization;

// Exercício 01 - letras a), b) e c)

// b) Mais 3 objetos com os cargos pedidos
Funcionario f1 = new Funcionario("Ana", "Gerente");
Funcionario f2 = new Funcionario("Bruno", "Desenvolvedor");
Funcionario f3 = new Funcionario("Carla", "Estagiário");

Funcionario[] funcionarios = { f1, f2, f3 };

foreach (Funcionario f in funcionarios)
{
    f.Apresentar();
    f.InformarSalario(); // c)
    Console.WriteLine();
}

class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; } // a) novo atributo cargo

    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome} | Cargo: {Cargo}");
    }

    // c) O salário NÃO é atributo: é calculado a partir do cargo
    public void InformarSalario()
    {
        double salario = Cargo switch
        {
            "Gerente" => 10000.00,
            "Desenvolvedor" => 5000.00,
            "Estagiário" => 100.00,
            _ => 0.00
        };

        Console.WriteLine($"Salário de {Nome} ({Cargo}): {salario.ToString("C", new CultureInfo("pt-BR"))}");
    }
}
