using System;
namespace lab02
{
    public class Plan 
    {
        public int m;
        public int me;

        public bool Memory()
        {

            if (me == 1)
            {
                m = 101;
                return true;
            }
            else if (me == 2)
            {
                m = 301;
                return true;
            }
            else if (me == 3)
            {
                m = 1001;
                return true;
            }
            else
            {
                Console.WriteLine("Debes ingresar una opcion valida");
                return false;
            }
        }
        





    }
}
