﻿using System.Text.Json;
namespace ScreenSound_04.Modelos
{
    internal class MusicasPreferidas
    {
        public string Nome { get; set; }

        public List<Musica> ListaDeMusicasFavoritas { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas  = new List<Musica>();
        }

        public void AdicionarMusicaFavorita(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
            foreach(var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }

        }

        public void GerarArquivoJson()
        {
            //aqui estou criando um objeto anonimo
            //aqui estou criando um objeto anonimo
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musica = ListaDeMusicasFavoritas
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine("O arquivo json foi criado com sucesso !");
        }

        public void GerarDocumentoTXTComAsMusicasFavoritas()
        {
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
            using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
            {
                arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
                foreach (var musicas in ListaDeMusicasFavoritas)
                {
                    arquivo.WriteLine($"- {musicas}");
                }
            }
            Console.WriteLine("txt gerado com sucesso!");
        }

    }
}
