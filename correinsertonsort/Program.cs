using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correinsertonsort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10,5,0,2,7,9 };

            for(int i=0;i<6;i++)
            {
                for(int j=i+1;j<6;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
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
