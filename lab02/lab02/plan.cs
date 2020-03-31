using System;
namespace lab02
{
    public class Plan 
    {
        
        public int m;

        public int Memory(int me)
        {

            if (me == 1)
            {
                m = 101;
                
                return m;
            }
            else if (me == 2)
            {
                m = 301;
                return m;
            }
            else if (me == 3)
            {
                m = 1001;
                return m;
            }
            else
            {
                Console.WriteLine("Debes ingresar una opcion valida");
                m = 0;
                return m; 
            }
            
        }
        





    }
}
