// See https://aka.ms/new-console-template for more information
using System;

class Program
{
  static int BinarySearch(int[] array, int item)
  {
    int low = 0;
    int high = array.Length - 1;
    while (low <= high)
    {
      int mid = (low + high) / 2;
      int guess = array[mid];
      if (guess == item)
      {
        return mid;
      }
      if (guess > item)
      {
        high = mid - 1;
      }
      else
      {
        low = mid + 1;
      }
    }
    return -1;
  }

  static void Main()
  {
    int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int item = 7;
    Console.WriteLine(BinarySearch(myArray, item));
  }
}
