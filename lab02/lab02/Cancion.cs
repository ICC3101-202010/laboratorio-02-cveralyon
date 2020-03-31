using System;
namespace lab02
{
    public class Cancion : Espotifai
    {
        // atributos
        public string nombre { get; set; }
        public string album { get; set; }
        public string artista { get; set; }
        public string genero { get; set; }

        public Cancion(string nombre, string album, string artista, string genero)
        {
            this.nombre = nombre;
            this.album = album;
            this.artista = artista;
            this.genero = genero;
        }

        public Cancion()
        {
        }

        //metodos
        public string Informacion()
        {
            string v = $"Genero: {genero}\nArtista: {artista}\nAlbum: {album}\nNombre: {nombre}";
            return v;
               
        }

        
    }
}

