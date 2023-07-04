using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5,4,10,1,6,2};

            for(int i=1;i<6;i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while(j>=0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = arr[j];
            }

            for(int i=0;i<6;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
