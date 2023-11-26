

// Dianroan - The fault in our programs
// Code challenge: 

using System;
using static System.Console;

public class Program {
    // Function to check if a number is a palindrome
    static public bool IsPalindrome(int x) {
        // If the number is negative, it cannot be a palindrome
        if(x<0) return false;

        // Flag to indicate whether the number is a palindrome
        bool flagIsPalindrome = true;

        // Convert the number to a string
        string s = "";
        while(x > 0) {
            int digito = x % 10; // Get the last digit of the number
            char digitoChar = (char)('0' + digito); // Convert the digit to a character
            s = digitoChar + s; // Add the digit to the beginning of the string
            x /= 10; // Remove the last digit from the number
        }

        // Compare the string with its reverse to check if it is a palindrome
        for(int i = 0, j = s.Length - 1; i < s.Length; i++, j--) {
            if(!(s[i] == s[j])) { // If the characters at positions i and j are not equal
                flagIsPalindrome = false; // The number is not a palindrome
            }
        }

        // Return the result
        return flagIsPalindrome; 
    }

    public static void Main(string[] args) {
        // Test the function with some examples
        WriteLine(IsPalindrome(121)); // Output: True
        WriteLine(IsPalindrome(-121)); // Output: False
        WriteLine(IsPalindrome(10)); // Output: False
    }
}
//
//This code checks if a given number is a palindrome. A palindrome is a number or a word that remains the same when its digits or characters are reversed. The function `IsPalindrome` takes an integer `x` as input and returns `true` if `x` is a pal