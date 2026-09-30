Fantasma blinky = new Fantasma("Perseguir o Pac-Man", "Blinky", "Vermelho");
Fantasma pinky = new Fantasma("Emboscar pela frente", "Pinky", "Rosa");

blinky.GerarFantasma();
blinky.Mover("esquerda");

Console.WriteLine();

pinky.GerarFantasma();
pinky.Mover("cima");

class Fantasma
{
    public string Habilidade { get; set; }
    public string Nick { get; set; }
    public string Cor { get; set; }

    public Fantasma(string habilidade, string nick, string cor)
    {
        Habilidade = habilidade;
        Nick = nick;
        Cor = cor;
    }

    public void GerarFantasma()
    {
        Console.WriteLine($"Habilidade: {Habilidade}");
        Console.WriteLine($"Nick: {Nick}");
        Console.WriteLine($"Cor: {Cor}");
    }

    public void Mover(string direcao)
    {
        Console.WriteLine($"{Nick} se moveu para {direcao}");
    }
}
