
// Dianroan - The fault in our programs
// Code challenge: RemoveElement

using System;
using static System.Console;

public class Program {
    // Function to remove all occurrences of a given element from the array
    static public int RemoveElement(int[] nums, int val) {
        // Create a new array to store the elements that are not equal to the given value
        int[] array = new int[nums.Length]; 
        int j = 0; // Variable to keep track of the current index in the new array

        // Iterate through each element in the original array
        for(int i = 0; i < nums.Length; i++){
            // If the current element is not equal to the given value, add it to the new array
            if(nums[i] != val){
                array[j] = nums[i];
                j++; // Increment the current index in the new array
            }
        }

        // Update the original array with the elements from the new array
        for(int i = 0; i < array.Length; i++){
            nums[i] = array[i];
        }

        // Return the length of the new array, which represents the count of elements that are not equal to the given value
        return j;
    }

    public static void Main(string[] args) {
        // Test the RemoveElement function with an example
        int[] nums = {3, 2, 2, 3};
        int val = 3;
        int length = RemoveElement(nums, val);
        WriteLine($"The length of the new array is: {length}");
        WriteLine($"The new array is: [{string.Join(", ", nums)}]");
    }
}
//
//In this code, the `RemoveElement` function takes an array of integers and a value as input. It creates a new