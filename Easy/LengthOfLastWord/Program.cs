

// Dianroan - The fault in our programs
// Code challenge: LengthOfLastWord

using System;
using static System.Console;

public class Program {
    // Function to calculate the length of the last word in a string
    static public int LengthOfLastWord(string s) {
        // Variable to store the length of the last word
        int length = 0;

        // Boolean variable to indicate if we are starting a new word
        bool newWord = false;

        // Loop through each character in the string
        for (int i = 0; i < s.Length; i++) {
            newWord = false;

            // Loop through the remaining characters in the string
            for (int j = i; j < s.Length; j++) {
                // If the current character is not a space, we are starting a new word
                if(s[j] != ' '){
                    newWord = true;
                }
            }

            // If we are starting a new word, check if the current character is a space
            if(newWord){
                if(s[i] == ' '){
                    length = 0;
                }
                else{
                    length++;
                }
            }
        }

        // Return the length of the last word
        return length;
    }

    public static void Main(string[] args) {
        // Test the function with some examples
        string s1 = "Hello World";
        string s2 = "   Fly me   to the moon ";
        string s3 = "luffy is still joyboy";

        WriteLine($"Length of last word in '{s1}': {LengthOfLastWord(s1)}");
        WriteLine($"Length of last word in '{s2}': {LengthOfLastWord(s2)}");
        WriteLine($"Length of last word in '{s3}': {LengthOfLastWord(s3)}");
    }
}
//
//This code provides a solution to the problem. The `LengthOfLastWord` function calculates the length of the last word in a string by iterating through each character and checking if it is the start of a new word. If it is, the function updates the length of the last word accordingly. The `Main` function tests the `