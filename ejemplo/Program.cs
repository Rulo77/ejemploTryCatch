using System;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {

             string nombre="Raul";
             string apellido="Gomez";
              int año=22;
       
            int age;
            try
            {
                if (año < 21)
                    throw new ArgumentOutOfRangeException("año", "todos los invitados deven de tener mas de 21 años");
                else
                    age = año;

                Console.WriteLine(nombre + " " + apellido + ", " + año);
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {

                Console.WriteLine("Error: {0}", outOfRange.Message);
            }
            Console.ReadKey();




        }
    }
}
