﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {
        //Array yang akan dicari
        int[] arr = new int[20];
        //Number of element in the array
        int n;
        //Get the number of element to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of element in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 element.\n");
            }
            //Accept array elemet
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("    Enter array element"      );
            Console.WriteLine("-----------------------------");
            for (i = 0; i < n; i++)
            {

            }
        }
    }
}
