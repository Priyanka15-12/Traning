using System;

namespace Training {
   class Program {
      static void Main (string[] args) {
         Console.Write ("Enter number: ");
         int num = int.Parse (Console.ReadLine ());
         string words = DecimalToWords (num);
         Console.WriteLine (words);
         string randomNumbers = DecimalToNumbers (num);
         Console.WriteLine (randomNumbers);
      }
      static string DecimalToWords (int num) {
         string[] nums = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
         string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

         if (num < 20) {
            return nums[num];
         } else if (num >= 20 && num < 100) {
            int numDigit = num / 10;
            int numRemainder = num % 10;
            return tens[numDigit] + ((numRemainder == 0) ? "" : (" " + nums[numRemainder]));
         } else if (num >= 100 && num < 1000) {
            int hundredsDigit = num / 100;
            int hunRemainder = num % 100;
            string words = nums[hundredsDigit] + " hundred ";
            if (hunRemainder != 0) {
               words += "and ";
               if (hunRemainder < 20)
                  words += nums[hunRemainder];
               else {
                  int hunTens = hunRemainder / 10; int hunOnes = hunRemainder % 10;
                  words += tens[hunTens] + ((hunOnes == 0) ? "" : (" " + nums[hunOnes]));
               }
            }
            return words;
         } else if (num >= 1000 && num < 100000) {
            return DecimalToWords (num / 1000) + " thousand " + (num % 1000 != 0 ? "" + DecimalToWords (num % 1000) : "");
         } else if (num >= 100000 && num < 10000000)
            return DecimalToWords (num / 100000) + " lakh " + (num % 100000 != 0 ? "" + DecimalToWords (num % 100000) : "");
         return ("Out of range.");
      }
      static string DecimalToNumbers (int num) {
         string[] romanLetters = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "XI", "V", "IV", "I" };
         int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
         string romanNumbers = "";
         if (num > 0 && num <= 3999) {
            for (int index = 0; index < numbers.Length; index++) {
               while (num >= numbers[index]) {
                  romanNumbers += romanLetters[index];
                  num -= numbers[index];
               }
            }
         }return romanNumbers;
            
      }
   }
}
