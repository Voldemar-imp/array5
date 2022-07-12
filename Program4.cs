using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySise = 30;
            int[] numbersArray = new int[arraySise];
            int randomMin = 3;
            int randomMax = 6;
            int previousNumber;
            int RepitNumber;
            int repitCount = 1;
            int maxRepitCount = 1;
            Random random = new Random(); 

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = random.Next(randomMin, randomMax);
                Console.Write(numbersArray[i] + " ");
            }

            Console.WriteLine("- массив");
            RepitNumber = numbersArray[0];
            previousNumber = numbersArray[0];
            Console.Write(repitCount + " ");

            for (int i = 1; i < numbersArray.Length; i++)
            {               
                if (numbersArray[i] == previousNumber)
                {
                    repitCount++;
                    Console.Write(repitCount + " ");
                }
                else
                {
                    repitCount = 1;
                    Console.Write(repitCount + " ");
                }

                if (repitCount > maxRepitCount)
                {
                    RepitNumber = numbersArray[i];
                    maxRepitCount = repitCount;
                }

                previousNumber = numbersArray[i];                
            }

            Console.WriteLine("- количество посторений");
            Console.WriteLine("Больше всего подряд повторялось число: " + RepitNumber);
            Console.WriteLine("Максимально количество повторений: " + maxRepitCount); 
        }
    }
}
