// Dianroan - The fault in our programs
// Code challenge: Two Sums

using System;
using static System.Console;

public class Program
{
    // Implement the TwoSum method
    static public int[] TwoSum(int[] nums, int target)
    {
        // Create an array to store the answer
        int[] answerArray = new int[2];
        // Calculate the difference between the target and the current number
        int comparator;

        // Loop through the array to find the numbers that add up to the target
        for (int arrayIndex = 0; arrayIndex < nums.Length; arrayIndex++)
        {
            comparator = target - nums[arrayIndex];

            // Loop through the array again, starting from the next index, to find the number that completes the sum
            for (int arrayIndexTwo = arrayIndex + 1; arrayIndexTwo < nums.Length; arrayIndexTwo++)
            {
                // If the current number equals the difference between the target and the first number, return their indices
                if (comparator == nums[arrayIndexTwo])
                {
                    answerArray[0] = arrayIndex;
                    answerArray[1] = arrayIndexTwo;
                    break;
                }
            }
        }
        return answerArray;
    }

    public static void Main(string[] args)
    {
    }
}