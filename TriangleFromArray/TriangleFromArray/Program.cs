using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFromArray
{
    class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //input
            //int[] arr= { 4,1,2 };
            int[] arr = { 5, 4, 3, 1, 2};
            bool possible=isPossibleTriangle(arr);
            Console.WriteLine(possible);
        }
        /// <summary>
        /// Function to check whether numbers in an array forms a triangle
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool isPossibleTriangle(int[] num)
        {
            int[] sortedArray;
            if (num.Length < 3)
            {
                return false;
            }
            //Sort the array
            sortedArray=quickSort(num,0,num.Length-1);

            for(int i = 0; i < sortedArray.Length - 2; i++)
            {
                if (sortedArray[i] + sortedArray[i + 1] > sortedArray[i + 2])
                {
                    return true;
                }
              
            }
            //returns false if none of the numbers can be used to create a triangle
            return false;
        }
        /// <summary>
        /// Function to sort .Uses QuickSort
        /// </summary>
        /// <param name="num"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static int[] quickSort(int[] num,int low,int high)
        {
            if (low < high)
            {
               
                int pi = Partition(num, low, high);
                //Sort first partition
                quickSort(num, low, pi - 1);
                //Sort second partition
                quickSort(num, pi + 1, high);
            }
            return num;
        }
        /// <summary>
        /// Creates partition for quick sort using pivot element
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];    //pivot element 
            int i = low ;  

            for (int j = low; j <= high - 1; j++)
            {
              //if current element is <= pivot; increment the index of current element
                if (arr[j] <= pivot)
                {
           
                    swap(ref arr[i], ref arr[j]);
                }
            }
            swap(ref arr[i + 1], ref arr[high]);
            return (i + 1);
        }
        /// <summary>
        /// Function to swap numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
