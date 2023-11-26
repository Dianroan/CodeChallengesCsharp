
// Dianroan - The fault in our programs
// Code challenge: Find the Index of the First Occurrence in a String

using System;
using static System.Console;

public class Program {
    // Function to find the first occurrence of a substring in a string
    static public int StrStr(string haystack, string needle) {
        // Initialize the position variable to -1 (indicating no match found)
        int position = -1;

        // Loop through each character in the haystack string
        for(int i = 0; i < haystack.Length; i++){
            // Check if the remaining length of the haystack string is greater than or equal to the length of the needle string
            if((i + needle.Length - 1) < haystack.Length){
                // Extract a substring from the haystack string, starting at the current position and with a length equal to the length of the needle string
                string strAux = haystack.Substring(i, needle.Length);

                // Compare the extracted substring with the needle string
                if(strAux == needle){
                    // If the substrings match, update the position variable with the current position
                    position = i;

                    // Return the position variable immediately, as we have found the first occurrence of the needle string in the haystack string
                    return position;
                }
            }
        }

        // If the function has not returned yet, it means no match was found. Therefore, return the position variable, which is still -1.
        return position;
    }

    public static void Main(string[] args) {
        // Test the function with some example inputs
        string haystack = "hello";
        string needle = "ll";
        int result = StrStr(haystack, needle);
        WriteLine($"The first occurrence of '{needle}' in '{haystack}' is at index {result}.");
    }
}
//
//This code defines a function called `StrStr` that takes two strings as input: a "haystack" string and a "needle" string. The function returns the index of the