using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace LengthNestingSolution.Classes
{
    public class Nesting
    {

        public List<double>? LengthList { get; set; } = new List<double>();
        public List<double>? Inventory { get; set; } = new List<double>();
        public List<double>? Nested { get; set; } = new List<double>();

        public void Nest()
        {
            double itemCmp = 0;

            foreach (double item in Inventory)
            {
                itemCmp = item;
                foreach (double length in LengthList)
                {
                    if (itemCmp > length)
                    {
                        Nested.Add(length);
                        itemCmp = item - length;
                    }
                }
            }
        }


        /* arr[] ---> Input Array
        data[] ---> Temporary array to
                    store current combination
        start & end ---> Starting and Ending
                            indexes in arr[]
        index ---> Current index in data[]
        r ---> Size of a combination
                to be printed 
        static void combinationUtil(int[] arr, int[] data,
                                    int start, int end,
                                    int index, int r)
        {
            // Current combination is
            // ready to be printed,
            // print it
            if (index == r)
            {
                for (int j = 0; j < r; j++)
                    Console.Write(data[j] + " ");
                Console.WriteLine("");
                return;
            }

            // replace index with all
            // possible elements. The
            // condition "end-i+1 >=
            // r-index" makes sure that
            // including one element
            // at index will make a
            // combination with remaining
            // elements at remaining positions
            for (int i = start; i <= end &&
                        end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                combinationUtil(arr, data, i + 1,
                                end, index + 1, r);
            }
        }

        // The main function that prints
        // all combinations of size r
        // in arr[] of size n. This
        // function mainly uses combinationUtil()
        static void printCombination(int[] arr,
                                        int n, int r)
        {
            for(int z = 0; z < r; z++)
            {
                // A temporary array to store
                // all combination one by one
                int[] data = new int[z]; //r in replace of z

                // Print all combination
                // using temporary array 'data[]'
                combinationUtil(arr, data, 0,
                                n - 1, 0, z); //r in replace of z
            }
            
        }

        // Driver Code
        static public void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int r = arr.Length - 1;
            int n = arr.Length;
            printCombination(arr, n, r);
        }
        */
    }
}
