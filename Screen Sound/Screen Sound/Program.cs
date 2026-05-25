Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duração = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duração = 367,
    Disponivel = false,
};

albumDoQueen.AdicionarMusicas(musica1);
albumDoQueen.AdicionarMusicas(musica2);

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();
// 1. Exibir a ficha técnica de uma música específica
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

Console.WriteLine("\n" + new string('-', 30) + "\n");

 //2. Exibir a lista completa do álbum
albumDoQueen.ExibirMusicaDoAlbum();

