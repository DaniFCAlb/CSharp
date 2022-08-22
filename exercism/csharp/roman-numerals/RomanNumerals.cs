using System;
using System.Collections.Generic;
public static class RomanNumeralExtension {
    public static string ToRoman(this int value) {
        string romanNumbersResult = "";
        int index = 0; 
        string[] romanNumbers = {"M", "CM", "D", "CD", "C","XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        int[] numbers = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};

        while (value > 0) {
            if (value >= numbers[index]) {
            value -= numbers[index];
            romanNumbersResult += romanNumbers[index];
            }
            else {
                index++;
            }
        }
        
        
        return romanNumbersResult.ToString();
    
   /* string romanNumbersResult = "";
    Dictionary <string, int> romanNumbers = new Dictionary<string, int> () { 
        {"M", 1000}, {"CM", 900}, {"D", 500}, {"CD", 400}, {"C", 100}, {"XC", 90}, 
        {"L", 50}, {"XL", 40}, {"X", 10}, {"IX", 9}, {"V", 5}, {"IV", 4}, {"I", 1}         
        };
    
        foreach (var item in romanNumbers) {
            if (value <= 0) {
                break;
            }
            while (value >= item.Value) {
                value -= item.Value;
                romanNumbersResult += item.Key;
            }
            
        }
        return romanNumbersResult;*/
    }
}