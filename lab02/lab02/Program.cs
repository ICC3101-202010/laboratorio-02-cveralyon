using System;

namespace lab02
{
    class MainClass
    {
        public void main(string[] args)
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



        }
 
    }
}

    




