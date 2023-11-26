
// Dianroan - The fault in our programs
// Code challenge: Two Sum II

using System;
using static System.Console;

public class Program {
    // Function to find the two numbers that add up to the target
    static public int[] TwoSum(int[] numbers, int target) {
        int[] answerArray = new int[2];
        int comparator;

        // Iterate through the array
        for (int arrayIndex = 0; arrayIndex < numbers.Length; arrayIndex++) {
            comparator = target - numbers[arrayIndex];

            // Iterate through the rest of the array to find the second number
            for (int arrayIndexTwo = arrayIndex + 1; arrayIndexTwo < numbers.Length; arrayIndexTwo++) {
                if (comparator == numbers[arrayIndexTwo]) {
                    answerArray[0] = arrayIndex + 1;
                    answerArray[1] = arrayIndexTwo + 1;
                    break;
                }
            }
        }
        return answerArray;
    }

    public static void Main(string[] args) {
        // Example usage
        int[] numbers = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum(numbers, target);
        WriteLine($"The two numbers that add up to {target} are at indices {result[0] - 1} and {result[1] - 1}.");
    }
}
//
//In this code, the `TwoSum` function iterates through the array and calculates the difference between the target and the current number. It then iterates through the rest of the array to find a number that equals this difference. The indices of the two numbers are stored in the `answerArray returned.
//
//The `Main` function demonstrates the usage of the `TwoSum` function with an example array and target..</s>