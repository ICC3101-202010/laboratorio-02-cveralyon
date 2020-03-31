using System;
namespace lab02
{
    public class Cancion
    {
        public Cancion() { }
        
        // atributos
        public string nombre { get; set; }
        public string album { get; set;  }
        public string artista { get; set;  }
        public string genero { get; set;  }

        //metodos
        public string Informacion()
        {
            return "Genero: " + genero + "\nArtista: " + artista + "\nAlbum: " + album + "\nNombre: " + nombre;
        }
    }
}
