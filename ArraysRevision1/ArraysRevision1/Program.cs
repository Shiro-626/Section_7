using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task1

       /*     string[] Names = new string[5];

            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine("Please enter in a name to add to the array");
                Names[i] = Console.ReadLine();
            }


            Console.ReadLine();

            //Task2

            int[] Numbers = new int[10];
            Random rand = new Random();
            double total = 0;

            for(int j = 0; j <Numbers.Length; j++)
            {
                Numbers[j] = rand.Next(1,10);
                total += Numbers[j];
            }
            Console.WriteLine($"The average of the numbers is: {total/Numbers.Length}");

            Console.ReadLine();
            */

            //Practice question

       /*     int[] nums = new int[20];
            Random rnd = new Random();


            for(int k = 0; k <nums.Length; k++)
            {
                nums[k] = rnd.Next(1,100);
                Console.Write(nums[k] + " ");

                
                
            }
            Array.Sort(nums);



            Console.ReadLine();

            */

            //

            int[] randArray = new int[50];
            Random rand = new Random();

            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = rand.Next(1,100);
                Console.Write(randArray[i] + " ");
            }



        }
    }
}
