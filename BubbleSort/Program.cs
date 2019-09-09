using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static int loops = 0;
        static int swaps = 0;
        static void Main(string[] args)
        {
            int[] arrayToSort = { 14, 65, 63, 1, 54, 89, 84, 9, 98, 57, 71, 18, 21, 84, 69, 28, 11, 83, 13, 42, 64, 58, 78, 82, 13, 9, 96, 14, 39, 89, 40, 32, 51, 85, 48, 40, 23, 15, 94, 93, 35, 81, 1, 9, 43, 39, 15, 17, 97, 52 };

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i] + " ");

            }
            Console.WriteLine();


            CocktailSharkersort(arrayToSort);

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Loops:" + loops);
            Console.WriteLine("Swaps:" + swaps);
            Console.ReadKey();



        }
        public static void Bubblesort(int[] arrayToSort)
        {
            bool sorted = false;
            int sort = 0;

            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {

                    //runs this if first number is bigger than next number in array
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        //swaps them
                        sort = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = sort;
                        sorted = false;
                        swaps++;


                    }


                    loops++;
                }

            }

        }




        public static void optimizedBubblesort(int[] arrayToSort)
        {
            bool sorted = false;
            int sort = 0;
            int length = arrayToSort.Length - 1;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < length; i++)
                {


                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        sort = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = sort;
                        sorted = false;
                        swaps++;


                    }


                    loops++;
                }
                length--;
            }

        }
        public static void CocktailSharkersort(int[] arrayToSort)
        {
            bool sorted = false;
            int sort = 0;
            int length = arrayToSort.Length - 1;
            int start = 0;
            
            while (!sorted)
            {
                sorted = true;
                for (int i = start; i < length; i++)
                {
                    

                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        sort = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = sort;
                        sorted = false;
                        swaps++;


                    }


                    loops++;
                }
                length--;
                for (int i = length; i > start; i--)
                {


                    if (arrayToSort[i] < arrayToSort[i - 1])
                    {
                        sort = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i - 1];
                        arrayToSort[i - 1] = sort;
                        sorted = false;
                        swaps++;


                    }


                    loops++;
                }
                
                start++;
              /* foreach(int i in arrayToSort)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();*/
                Console.ReadKey();

            }

        }
    }



}
