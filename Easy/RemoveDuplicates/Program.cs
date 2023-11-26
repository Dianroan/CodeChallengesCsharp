

// Dianroan - The fault in our programs
// Code challenge: RemoveDuplicates

using System;
using System.Collections.Generic;
using static System.Console;

public class Program {
    // Function to remove duplicates from an array
    static public int RemoveDuplicates(int[] nums) {
        // List to store unique numbers
        List<int> uniqueNumbers = new List<int>();

        // Boolean variable to check if the current number is different from the unique numbers
        bool isDifferent = true;

        // Loop through each number in the array
        for(int indexNums = 0; indexNums < nums.Length; indexNums++) {       
            // Loop through each unique number
            for(int indexUniqueNumbers = 0; indexUniqueNumbers < uniqueNumbers.Count; indexUniqueNumbers++) {
                // If the current number is equal to a unique number, set isDifferent to false and break the loop
                if(nums[indexNums] == uniqueNumbers[indexUniqueNumbers]) {
                    isDifferent = false;
                    break;
                }
                // If the current number is not equal to any unique number, set isDifferent to true
                else {
                    isDifferent = true;
                }
            }
            // If the current number is different from the unique numbers, add it to the uniqueNumbers list
            if(isDifferent) {
                uniqueNumbers.Add(nums[indexNums]);
            }
        }

        // Overwrite the original array with the unique numbers
        for (int i = 0; i < uniqueNumbers.Count; i++) {
            nums[i] = uniqueNumbers[i];
        }

        // Return the count of unique numbers
        return uniqueNumbers.Count;
    }

    public static void Main(string[] args) {
        // Test the RemoveDuplicates function
        int[] nums = {1, 1, 2, 2, 3, 3, 4, 4, 5, 5};
        int length = RemoveDuplicates(nums);
        WriteLine($"Length after removing duplicates: {length}");
        WriteLine($"Array after removing duplicates: [{string.Join(", ", nums)}]");
    }
}
//
//In this code, the `RemoveDuplicates` function takes an array of integers as input and returns the count of unique numbers. The function uses a nested loop to compare each number in the array with the unique numbers. If a number is different from all the unique numbers, it is added to the uniqueNumbers list. Finally, the original array is overwritten with the unique numbers.
//
//The `Main` function tests the `RemoveDuplicates` function with a sample array. The output will display the length of the array after removing duplicates and the array after removing duplicates..</s>