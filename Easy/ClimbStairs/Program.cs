
// Dianroan - The fault in our programs
// Code challenge: ClimbStairs

using System;
using static System.Console;

public class Program {
    // Function to calculate the number of ways to climb a staircase
    static public int ClimbStairs(int n) {
        // Base cases: If there are 0 or 1 stairs, there is only 1 way to climb them
        if (n <= 2) return n;

        // Initialize variables to store the number of ways to climb the first, second, and third stairs
        int first = 1;
        int second = 2;
        int third;

        // Iterate through the stairs from the 4th to the nth stair
        for (int i = 3; i <= n; i++) {
            // Calculate the number of ways to climb the current stair (third) by adding the number of ways to climb the first and second stairs
            third = first + second;

            // Update the first and second stairs to the second and third stairs, respectively
            first = second;
            second = third;
        }

        // Return the number of ways to climb the nth stair
        return second;
    }

    public static void Main(string[] args) {
        // Test the ClimbStairs function with a few examples
        WriteLine(ClimbStairs(0)); // Output: 0
        WriteLine(ClimbStairs(1)); // Output: 1
        WriteLine(ClimbStairs(2)); // Output: 2
        WriteLine(ClimbStairs(3)); // Output: 3
        WriteLine(ClimbStairs(3)); // Output: 3
    }
}