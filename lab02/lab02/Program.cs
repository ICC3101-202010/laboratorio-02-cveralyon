using System;

namespace lab02
{
    class MainClass
    {
        static void Main()
        {
            int opcion;
            Console.WriteLine("Bienvenido a la plataforma de Espotifai, donde podras guardar y ver todas tus canciones favoritas\n\n");
            Console.WriteLine("Para Comenzar debes elegir unos de los 3 planes que tenemos para ti");

            Espotifai esp = new Espotifai();
            esp.Contratacion();
            Console.WriteLine("Felicidades, te has suscrito\n");
            Console.WriteLine("\n");
            do
            {
                Console.WriteLine("\t\t\t\t\t------MENU-----\n");
                Console.WriteLine("1 -->  Ver Todas mis canciones\n");
                Console.WriteLine("2 -->  Agregar una nueva Cancion\n");
                Console.WriteLine("3 -->  Ver Canciones Por Criterio\n\n");
                Console.WriteLine("4 -->  Salir de Espotifai\n");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        esp.VerCanciones();
                        break;
                    case 2:
                        esp.AgregarCancion();
                        break;
                    case 3:
                        int criterio;
                        string valor;
                        Console.WriteLine("Como Deseas ordenar tus canciones?\n" +
                                            "\t\t 1 --> Por Genero\n" +
                                            "\t\t 2 --> Por Artista\n" +
                                            "\t\t 3 --> Por Album\n" +
                                            "\t\t 4 --> Por Nombre (canciones que tengan igual nombre)");
                        criterio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba el nombre del criterio seleccionado. (nombre del artista o almbum, tipo de genero o nombre de la cancion");
                        valor = Console.ReadLine();
                        Console.WriteLine(esp.CancionesPorCriterio(criterio, valor));
                        break;
                    case 4:
                        break;
                                      
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
            }
            while (opcion != 3);
            
        }
 
    }
}

    




