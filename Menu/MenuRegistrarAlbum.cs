namespace PrimeiroProjeto.Menu;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {

            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Banda banda = bandasRegistradas[nomeDaBanda];
            banda.AdicionarAlbum(new Album(tituloAlbum));
            Console.Write($"O Album {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso! ");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.Write($"\nA banda {nomeDaBanda} não foi encontrado!");
            Console.Write("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine($"O álbum da {nomeDaBanda} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
