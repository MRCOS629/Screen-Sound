class Musica
{

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public Banda Artista { get; }
    public string Nome { get; }
    public int Duração { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida
    {
        get
        {
            string textoResumo = $"A música {Nome} é da banda {Artista}";
            return textoResumo;
        }
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"duração: {Duração}");
        if (Disponivel)
        {
            Console.WriteLine("A música está disponível no plano");
        } else
        {
            Console.WriteLine("Assine o plano plus para ver essa música!");
        }
    }
}