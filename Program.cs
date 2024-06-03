using System;

namespace BinarySearch
{
    internal class Program
    {
        public static int BinarySearch(int[] arr, int size, int value)
        {
            int low = 0;
            int high = size - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2; // Calculate the middle index

                if (arr[mid] == value)
                {
                    return mid; // Value found, return the index
                }
                else if (arr[mid] < value)
                {
                    low = mid + 1; // Search in the right half
                }
                else
                {
                    high = mid - 1; // Search in the left half
                }
            }
            return -1; // Value not found
        }

        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 20 };
            int result = BinarySearch(arr, arr.Length, 15);
            Console.WriteLine($"15 occurs at position: {result}");
            Console.ReadLine();
        }
    }
}