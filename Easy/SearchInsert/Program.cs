
// Dianroan - The fault in our programs
// Code challenge: SearchInsert

using System;
using static System.Console;

public class Program {
    // Function to search for a target number in a sorted array
    // If the target number is found, return its position
    // If the target number is not found, return the position where it should be inserted
    static public int SearchInsert(int[] nums, int target) {
        int position = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == target || nums[i] > target){
                position = i;
                return position;
            }
        }
        return nums.Length;
    }

    public static void Main(string[] args) {
        // Example usage:
        int[] nums = {1, 3, 5, 6};
        int target = 5;
        int position = SearchInsert(nums, target);
        WriteLine($"The position of {target} in the array is {position}.");
    }
}
//
//In this code, the `SearchInsert` function takes a sorted array `nums` and a target number `target` as input. It iterates through the array and checks if each number is equal to the target or greater than the target. If it finds a number that meets either condition, it returns the position of that number. If the function iterates through the entire array without finding a suitable number, it returns the length of the array, indicating that the target number should be inserted at the end of the array..</s>