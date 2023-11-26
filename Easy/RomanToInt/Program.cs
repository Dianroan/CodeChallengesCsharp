

// Dianroan - The fault in our programs
// Desafío de código: RomanToInt

using System;
using System.Collections.Generic;
using static System.Console;

public class Program {
    // This method converts a Roman number to an integer
    static public int RomanToInt(string romanNumber) {
        int integerNumer = 0;
        Dictionary<char, int> directorio = new Dictionary<char, int>(); 
        // The directorio dictionary contains the Roman numerals as keys and their corresponding integer values as values
        directorio['I'] = 1;
        directorio['V'] = 5;
        directorio['X'] = 10;
        directorio['L'] = 50;
        directorio['C'] = 100;
        directorio['D'] = 500;
        directorio['M'] = 1000;
        // Iterate through the Roman number
        for(int i = 0; i < romanNumber.Length - 1; i++) {
            // If the current Roman numeral is smaller than the next one, subtract its value from the integer number
            if(directorio[romanNumber[i]] < directorio[romanNumber[i + 1]]) {
                integerNumer -= directorio[romanNumber[i]];
            }
            // Otherwise, add its value to the integer number
            else {
                integerNumer += directorio[romanNumber[i]];
            }
        }
        // Add the value of the last Roman numeral to the integer number
        return integerNumer + directorio[romanNumber[romanNumber.Length - 1]];
    }
    public static void Main(string[] args) {

    }
}
//
//This code converts a Roman number to an integer. It uses a dictionary called `directorio` to store the Roman numerals and their corresponding integer values. The `RomanToInt iterates through the Roman number and checks if each Roman numeral is smaller than the next one. If it is, the method subtracts the Roman numeral's value from the integer number. Otherwise, the method adds the Roman numeral's value to the integer number. Finally, the method returns the integer number..</s>