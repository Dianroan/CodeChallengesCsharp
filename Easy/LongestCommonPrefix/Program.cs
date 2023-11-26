
// Dianroan - The fault in our programs
// Code challenge: LongestCommonPrefix

using System;
using static System.Console;

public class Program {
    // Function to find the longest common prefix in an array of strings
    static public string LongestCommonPrefix(string[] strs) {
        string commonPrefix = "";        // Initialize the common prefix as an empty string
        bool flagPrefix = true;          // Initialize a flag to check if the prefix is common
        string auxPrefix = strs[0];       // Initialize a variable to hold the first string in the array

        // Iterate through each character in the first string
        for(int i = 0; i < auxPrefix.Length; i++) {
            try {
                // Iterate through each string in the array, starting from the second string
                for(int j = 1; j < strs.Length; j++) {
                    // If the character at the current index in the first string is not equal to the character at the same index in the current string, set the flag to false and break the loop
                    if(auxPrefix[i] != strs[j][i]) {
                        flagPrefix = false;
                        break;
                    }
                }
                // If the flag is still true after checking all the strings, add the current character to the common prefix
                if(flagPrefix) {
                    commonPrefix = commonPrefix + auxPrefix[i];
                }
                // If the flag is false, break the loop
                else {
                    break;
                }
            }
            catch(Exception) {
                // If an exception occurs, break the loop
                break;
            }
        }
        // Return the longest common prefix
        return commonPrefix;
    }

    public static void Main(string[] args) {
        // Test the function with an example
        string[] strs = { "flower", "flow", "flight" };
        WriteLine(LongestCommonPrefix(strs)); // Output: "fl"
    }
}
//
//This code defines a function called `LongestCommonPrefix` that takes an array of strings as input and returns the longest common prefix among all the strings in the array. The function uses a nested loop to compare the characters at each index in the strings. If a common prefix is found, it is added to the `commonPrefix` string. The function returns the `commonPrefix` string after iterating through all the characters in the first string..</s>