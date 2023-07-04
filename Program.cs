using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {7,4,10,8,3,1 };
            for(int i=0;i<6-1;i++)
            {
                int min = i;
                for(int j=i+1;j<6;j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min= j;
                    }
                }
                if(min!=i)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }

            for(int i=0;i<6;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
