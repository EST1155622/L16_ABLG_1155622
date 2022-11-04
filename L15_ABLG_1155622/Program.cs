using System;

namespace L15_ABLG_1155622
{
    class Program
    {


        public static int[,] tabla = new int[40, 50];

       

        static void Main(string[] args)
        {

            int sumap = 0;
            int suman = 0;

            Random rnd = new Random();
         
            for (int i = 0; i < 40; i++)
            {
                for (int j=0; j<50; j++)
                {
                    tabla[i, j] = rnd.Next(-100, 100); 
                   
                }
            }

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (tabla [i,j] < 0)
                    {
                        //tabla[i, j] = sumap;
                        suman = suman + tabla[i, j];  
                        //Console.WriteLine(sumap); 
                    }
                }
            }

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (tabla[i, j] > 0)
                    {
                        //tabla[i, j] = suman;
                        sumap = sumap + tabla[i, j];
                        //Console.WriteLine(suman); 
                    }
                }
            }

            Console.WriteLine(sumap);
            Console.WriteLine(suman); 
        }
    }
}
