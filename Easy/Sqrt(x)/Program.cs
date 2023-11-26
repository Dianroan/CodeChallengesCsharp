
// Dianroan - The fault in our programs
// Code challenge: Sqrt(x)

using System;
using static System.Console;

public class Program {
    // Function to calculate the square root of a given number
    static public int MySqrt(int x) {
        // Initialize the square root variable
        double sqrt = 0;

        // Iterate through each number up to the given number
        for (double i = 0; i <= x; i++){
            // Check if the square of the current number is equal to the given number
            if((i * i) == x){
                // If it is, set the square root to the current number
                sqrt = i;
                break;
            }
            // Check if the square of the is greater than the given number
            else if((i * i) > x){
                // If it is, set the square root to the previous number
                sqrt = i - 1;
                break;
            }
        }

        // Convert the square root to an integer and return it
        return Convert.ToInt32(sqrt);
    }

    public static void Main(string[] args) {
        // Test the function with some example inputs
        WriteLine(MySqrt(4)); // Output: 2
        WriteLine(MySqrt(9)); // Output: 3
        WriteLine(MySqrt(16)); // Output: 4
        WriteLine(MySqrt(25)); // Output: 5
    }
}
//
//This code defines a function called `MySqrt` that calculates the square root of a given number. The function iterates through each number up to the given number and checks if the square of the current number is equal to the given number.