

// Dianroan - The fault in our programs
// Code challenge: FindMedianSortedArrays

using System;
using static System.Console;

public class Program {
    // Function to find the median of two sorted arrays
    static public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        double median = 0;
        double[] array = new double[nums1.Length + nums2.Length];
        for (int i = 0; i < nums1.Length; i++){
            array[i] = nums1[i];
        }
        for (int i = 0; i < nums2.Length; i++){
            array[i + nums1.Length] = nums2[i];
        }
        Array.Sort(array);
        if(array.Length % 2 == 0){
            median = ((array[(array.Length/2) - 1] + array[(array.Length/2)])) / 2;
        }
        else{
            median = array[array.Length/2];
        }
        return median; 
    }

    // Main function to test the solution
    public static void Main(string[] args) {
        int[] nums1 = {1, 3, 4};
        int[] nums2 = {2};
        double median = FindMedianSortedArrays(nums1, nums2);
        WriteLine($"The median of the two arrays is: {median}");
    }
}
// have a
//In this code, we function called `FindMedianSortedArrays` that takes two integer arrays as input. The function combines the two arrays into a new array called `array`. Then, it sorts the `array` in ascending order.
//
//After sorting, the function checks if the length of the `array` is even or odd. If it's even, the median is calculated as the average of the two middle numbers. If it's odd, the median is the middle number.
//
//Finally, the function returns the calculated median.
//
//The `Main` function is used to test the solution. It creates two integer arrays called `nums1` and `nums2`, and then calls the `FindMedianSortedArrays` function with these two arrays as arguments. The result is printed to the console..</s>