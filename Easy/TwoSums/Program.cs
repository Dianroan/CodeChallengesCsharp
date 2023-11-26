// Dianroan - The fault in our programs
// Desafío de código: Two Sums

// Importamos algunas "herramientas" que necesitamos para nuestro programa
using System;
using static System.Console;

public class Program {
    static public int[] TwoSum(int[] nums, int target) {
        int[] answerArray = new int[2];
        int comparator;
        for (int arrayIndex = 0; arrayIndex < nums.Length; arrayIndex++) {
            comparator = target - nums[arrayIndex];
            for (int arrayIndexTwo = arrayIndex + 1; arrayIndexTwo < nums.Length; arrayIndexTwo++) {
                if (comparator == nums[arrayIndexTwo]) {
                    answerArray[0] = arrayIndex;
                    answerArray[1] = arrayIndexTwo;
                    break;
                }
            }
        }
        return answerArray;
    }

    public static void Main(string[] args) {
    }
}