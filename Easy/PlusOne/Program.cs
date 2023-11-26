
// Dianroan - The fault in our programs
// Code challenge: PlusOne

using System;
using static System.Console;

public class Program {
    // Function to add 1 to an array of digits
    static public int[] PlusOne(int[] digits) {
        // Initialize carry as 1
        int carry = 1;

        // Iterate through the array in reverse order
        for (int i = digits.Length - 1; i >= 0; i--) {
            // Calculate the sum of the current digit and the carry
            int sum = digits[i] + carry;

            // Update the current digit with the remainder of the sum divided by 10
            digits[i] = sum % 10;

            // Update the carry with the quotient of the sum divided by 10
            carry = sum / 10;

            // If the carry is 0, break out of the loop
            if (carry == 0)
                break;
        }

        // If the carry is greater than 0, it means a new digit has been added to the front of the array
        if (carry > 0) {
            // Create a new array with a size one greater than the original array
            int[] result = new int[digits.Length + 1];

            // Set the first element of the new array to the carry
            result[0] = carry;

            // Copy the elements of the original array to the new array starting from the second element
            Array.Copy(digits, 0, result, 1, digits.Length);

            // Return the new array
            return result;
        }

        // If the carry is 0, it means no new digit has been added to the front of the array
        // Return the original array
        else {
            return digits;
        }
    }

    public static void Main(string[] args) {
        // Test the function with an example
        int[] digits = {1, 2, 3}; 
        int[] result = PlusOne(digits);

        // Print the result
        foreach (int digit in result) {
            Write(digit);
        }
    }
}

//
//This code defines a function called `PlusOne` that takes an array of digits as input and returns a new array