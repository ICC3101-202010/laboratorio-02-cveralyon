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
                Console.WriteLine("3 -->  Salir de Espotifai\n");
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

    




