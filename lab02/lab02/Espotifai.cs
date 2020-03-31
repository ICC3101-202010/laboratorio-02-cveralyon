using System;
namespace lab02
{
    public class Espotifai : Plan
    {
        static int memo;
        public void Contratacion()// aqui se selecciona de cuanta "memoria" sera el arreglo de objetos
        {
            Plan p = new Plan();
            int v;
            while (p.Memory() == false)
            {
                Console.WriteLine("Introduzca el numero de plan que desea contratar:\n " +
                   "\t\t Plan 1: Plan basico que incluye un espacio para almacenar hasta 100 canciones\n" +
                   "\t\t Plan 2: Plan medio que incluye un espacio para almacenar hasta 300 canciones\n" +
                   "\t\t Plan 3: Plan Premium que incluye un espacio para almacenar hasta 1000 canciones\n");


                v = int.Parse(Console.ReadLine());
                p.me = v;
            }
        memo = p.m;
        }
        Cancion[] repertorio = new Cancion[memo];

        
        public bool AgregarCancion()      
        {
            
            string n;
            string g;
            string al;
            string art;
            bool aux = true;

            

            if (aux == true) { 

                Console.WriteLine("Introduzca el nombre de la cancion que desea agregar: ");
                n = Console.ReadLine();
                Console.WriteLine("Introduzca genero de la cancion: ");
                g = Console.ReadLine();
                Console.WriteLine("Introduzca el nombre del Album al que pertenece la cancion: ");
                al = Console.ReadLine();
                Console.WriteLine("Introduzca el nombre del Artista: ");
                art = Console.ReadLine();

                for (int i = 1; i <= repertorio.Length; i++)
                {
                    if (repertorio[i].nombre == n && repertorio[i].genero == g && repertorio[i].album == al && repertorio[i].artista == art)
                    {
                        aux = false;
                        return aux;
                    }
                    else
                    {
                        for (int e = 1; e <= repertorio.Length; e++)
                        {
                            repertorio[e] = new Cancion(n, g, al, art);                         
                          
                        }
                        aux = true;
                        return aux;
                    }

                }
                
            }
            else
            {
                return aux;
            }
            return aux;


            
        }
        public void VerCanciones()
        {
            for (int u = 0;  u <= repertorio.Length; u++)
            {
                Console.WriteLine(repertorio[u].Informacion());
            } 

        }
    }
}
