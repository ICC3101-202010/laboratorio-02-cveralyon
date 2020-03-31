using System;
namespace lab02
{
    public class Espotifai : Cancion
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

                for (int i = 0; i < repertorio.Length; i++)
                {
                    if (repertorio[i].nombre == n && repertorio[i].genero == g && repertorio[i].album == al && repertorio[i].artista == art)
                    {
                        aux = false;
                        return aux;
                    }
                    return aux;
                }
                
                if ( aux == true)
                {
                    for (int e = 0; e < repertorio.Length; e++)
                    {
                        repertorio[e] = new Cancion(n, g, al, art);                         
                          
                    }
                    aux = true;
                    return aux;
                }
                return aux;                
            }
            return aux;


            
        }

        public void VerCanciones()
        {
            Console.WriteLine("\t\t\tLISTA DE CANCIONES: \n");
            for (int u = 0;  u < repertorio.Length; u++)
            {
                string[] ver = new string[repertorio.Length];
                ver[0] = " " + repertorio[0] + " \n ";
                Console.WriteLine(ver);
            }
            
        }

        public Cancion[] CancionesPorCriterio( int criterio, string valor)
        {

            switch (criterio)
            {
                case 1://genero
                    int cont = 0;
                    for (int i = 0; i < repertorio.Length; i++)
                    {
                        if (repertorio[i].genero == valor)
                        {
                            cont += 1;
                        }                       
                    }
                    Cancion[] canc = new Cancion[cont];
                    for (int i = 0; i < repertorio.Length; i++)
                    {
                        if (repertorio[i].genero == valor)
                        {                            
                            canc[i] = repertorio[i];
                        }
                        
                    }
                    return canc;
                case 2:// artista
                    int cont1 = 0;
                    for (int i = 0; i < repertorio.Length; i++)
                    {
                        if (repertorio[i].artista == valor)
                        {
                            cont1 += 1;
                        }
                    }
                    Cancion[] canc1 = new Cancion[cont1];
                    for (int i = 0; i < repertorio.Length; i++)
                    {
                        if (repertorio[i].artista == valor)
                        {
                            canc1[i] = repertorio[i];
                            return canc1;
                        }
                        return canc1;
                    }
                    return  canc1;
                case 3://album
                    int cont2 = 0;
                    for (int i = 0; i < repertorio.Length; i++)
                    {
                        if (repertorio[i].album == valor)
                        {
                            cont2 += 1;
                        }
                    }
                    Cancion[] canc2 = new Cancion[cont2];
                    for (int i = 0; i < repertorio.Length; i++)
                    {
                        if (repertorio[i].album == valor)
                        {
                            canc2[i] = repertorio[i];
                            return canc2;
                        }
                        return canc2;
                    }
                    return canc2;
                case 4://nombre
                    int cont3 = 0;
                    for (int i = 0; i < repertorio.Length; i++)
                    {
                        if (repertorio[i].nombre == valor)
                        {
                            cont3 += 1;
                      
                        }
                    }
                    Cancion[] canc3 = new Cancion[cont3];
                    for (int i = 0; i < repertorio.Length; i++)
                    {
                        if (repertorio[i].nombre == valor)
                        {
                            canc3[i] = repertorio[i];
                            return canc3;
                        }
                        return canc3;
                    }
                    return canc3;
                default:
                    Cancion[] canc4 = new Cancion[0];
                    Console.WriteLine("\t\t\t-----ERROR-----\n");
                    Console.WriteLine("\t\t\tINGRESE UNA OPCION VALIDA");
                    return canc4;
                    
            }
             

        }       
    }
}
