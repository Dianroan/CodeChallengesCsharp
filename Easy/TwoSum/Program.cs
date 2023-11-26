

// Dianroan - The fault in our programs
// Code challenge: Two Sums

using System;
using static System.Console;

public class Program {
    // Function to find the two numbers that add up to the target
    static public int[] TwoSum(int[] nums, int target) {
        // Create an array to store the answer
        int[] answerArray = new int[2];
        // Calculate the difference between the target and the current number
        int comparator;

        // Loop through the array to find the numbers that add up to the target
        for (int arrayIndex = 0; arrayIndex < nums.Length; arrayIndex++) {
            comparator = target - nums[arrayIndex];

            // Loop through the array again, starting from the next index, to find the number that completes the sum
            for (int arrayIndexTwo = arrayIndex + 1; arrayIndexTwo < nums.Length; arrayIndexTwo++) {
                // If the current number equals the difference between the target and the first number, return their indices
                if (comparator == nums[arrayIndexTwo]) {
                    answerArray[0] = arrayIndex;
                    answerArray[1] = arrayIndexTwo;
                    break;
                }
            }
        }
        return answerArray;
    }

    public static void Main(string[] args) {
        // Example usage
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum(nums, target);
        WriteLine($"The two numbers that add up to {target} are at indices {result[0]} and {result[1]}.");
    }
}

//
//In this code, we have a function called `TwoSum` that takes an array of integers and a target integer as input. The function iterates through the array and calculates the difference between the target and the current number. It then iterates through the array again, starting from the next index, to find the number that completes the sum. If it finds such a number, it returns the indices of the two numbers.
//
//The `Main` function demonstrates the usage of the `TwoSum` function with an example array and target..</s>