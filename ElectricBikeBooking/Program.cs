using System;

namespace ElectricBikeBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Interval[] arr1 = { new Interval(1, 4),
                        new Interval(2, 5),
                        new Interval(7, 9) };
            int n1 = arr1.Length;

            if (CheckOverlap(arr1, n1))
            {
                Console.Write("False\n");//if it overlaps its false as the bike is not avalable else it available
            }
            else
            {
                Console.Write("True\n");
            }
            Interval[] arr2 = { new Interval(6, 7),
                        new Interval(2, 4),
                        new Interval(8, 12)};
            int n2 = arr2.Length;
            if (CheckOverlap(arr2, n2))
            {
                Console.Write("False\n");//if it overlaps its false as the bike is not avalable else it available
            }
            else
            {
                Console.Write("True\n");
            }

            Interval[] arr3 = { new Interval(4, 5),
                        new Interval(2, 3),
                        new Interval(3, 6)};
            int n3 = arr3.Length;

            if (CheckOverlap(arr3, n3))
            {
                Console.Write("False\n");//if it overlaps its false as the bike is not avalable else it available
            }
            else
            {
                Console.Write("True\n");

            }
        }
        // An interval has bike start time and end time  
        public class Interval
        {
            public int start;
            public int end;
            public Interval(int start, int end)
            {
                this.start = start;
                this.end = end;
            }
        };

        // Function to check if any two intervals overlap  
        static bool CheckOverlap(Interval[] arr, int n)
        {
            int max_ele = 0;

            // Find the overall maximum element  
            for (int i = 0; i < n; i++)
            {
                if (max_ele < arr[i].end)
                    max_ele = arr[i].end;
            }

            // Initialize an array of size max_ele  
            int[] aux = new int[max_ele + 1];
            for (int i = 0; i < n; i++)
            {

                // starting point of the interval  
                int x = arr[i].start;

                // end point of the interval  
                int y = arr[i].end;
                aux[x]++;
                aux[y]--;
            }

            for (int i = 1; i <= max_ele; i++)
            {
                // Calculating the prefix Sum  
                aux[i] += aux[i - 1];

                // Overlap  
                if (aux[i] > 1)
                    return true;
            }

            // If we reach here, then no Overlap  
            return false;
        }
    }
}

