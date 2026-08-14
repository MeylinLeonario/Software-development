using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_5
{
    public class Guess : IGuess
    {

        public int GuessNumber(int randomNumber)
        {
            
            Console.WriteLine("Adivina el número.");
            int numeroAdivinado;
            while (true) {
                try
                {
                    numeroAdivinado = Convert.ToInt32(Console.ReadLine());
                    break;
                } catch
                {
                    Console.WriteLine("Ingresa un número válido del 0 al 10");
                }
        
            }
            
            while (numeroAdivinado!= randomNumber)
            {
                if (numeroAdivinado < randomNumber)
                {
                    Console.WriteLine("Es un número mayor.");
                    numeroAdivinado = Convert.ToInt32(Console.ReadLine());
                }
                if (numeroAdivinado > randomNumber)
                {
                    Console.WriteLine("Es un número menor.");
                    numeroAdivinado = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("¡Lo adivinaste!");
            return randomNumber;
        }
    }
}