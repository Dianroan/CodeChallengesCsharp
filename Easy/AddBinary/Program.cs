
// Dianroan - The fault in our programs
// Code challenge: AddBinary

using System;
using static System.Console;

public class Program {
    // Function to add binary numbers
    static public string AddBinary(string a, string b) {
        // Initialize carry
        int carry = 0;

        // Initialize pointers for a and b
        int i = a.Length - 1; 
        int j = b.Length - 1; 

        // Initialize result string
        string result = "";  

        // Loop through each digit of a and b
        while (i >= 0 || j >= 0 || carry > 0)
        {
            // Calculate sum of digits at current position
            int sum = carry; 
            if (i >= 0)
            {
                sum += a[i] - '0'; // Convert char to int
                i--; 
            }
            if (j >= 0)
            {
                sum += b[j] - '0'; // Convert char to int
                j--; 
            }

            // Append the sum modulo 2 to the result string
            result = (sum % 2) + result; 

            // Update carry for next iteration
            carry = sum / 2; 
        }

        // Return the result string
        return result;
    }

    public static void Main(string[] args) {
        // Test the function with example inputs
        string a = "11";
        string b = "1";
        string result = AddBinary(a, b);
        WriteLine($"The sum of {a} and {b} is {result}");
    }
}
//
//This code defines a function called `AddBinary` that takes two strings representing binary numbers. It calculates the sum of these binary numbers and returns the result as a string. The function uses a while loop to iterate through each digit of the binary numbers. It calculates the sum of the digits at each position and updates the carry for the next iteration. The result string is built by appending the sum modulo 2 at each position. The `Main` function tests the `AddBinary` function with example inputs..</s>