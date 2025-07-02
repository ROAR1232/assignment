using System.Reflection.Metadata

namespace Assignment_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to enter a number then print it.

            Console.Write("Enter a number: ")
            string input1 = Console.ReadLine()
            Console.WriteLine("You entered: " + input1)

            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            string str = "123abc"
            bool success = int.TryParse(str, out int parsedStr)
            if (success)
            {
                Console.WriteLine("Number: " + parsedStr)
            }
            else
            {
                Console.WriteLine("Cannot convert: The string contains non-numeric characters.")
            }

            #endregion

            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            float a = 10.5f
            float b = 2.5f
            float result = a + b
            Console.WriteLine("Result : " + result)

            #endregion
            
            #region Q4 - Write C# program that Extract a substring from a given string.
            string text = "Hello World!"
            string sub = text.Substring(6, 5)
            Console.WriteLine("Extracted substring: " + sub)

            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int x = 5
            int y = x
            y = 10
            Console.WriteLine("x = " + x)
            Console.WriteLine("y = " + y)
            // value types are copied by value so changing one don't affect the other
            #endregion

            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            int[] arr1 = { 1, 2, 3 }
            int[] arr2 = arr1
            arr2[0] = 99
            Console.WriteLine("arr1[0] = " + arr1[0]) //99
            // reference types point to the same object in memory and arr2 first value becoms unreachable in the heap 

            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 

            string str1 = "hello "
            string str2 = "world!"
            string combined = $"{str1} + {str2}"
            Console.WriteLine("combined: " + combined)
            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.
            double principal = 1000
            double rate = 5
            double time = 2
            double interest = (principal * rate * time) / 100
            Console.WriteLine("simple Interest = " + interest)

            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)
            double weight = 70
            double height = 1.75
            double bmi = weight / (height * height)
            Console.WriteLine("BMI = " + bmi)

            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"

            int temp = 25
            string weather
            if (temp > 30)
            { weather = 'just hot'}
            else if (temp < 10)
            {weather = 'just cold' }
            else
            { weather = 'just good' }


            Console.WriteLine("Weather: " + weather)
            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001
            int day, month, year

            Console.Write("Enter Day: ")
            bool isDayValid = int.TryParse(Console.ReadLine(), out day)

            Console.Write("Enter Month: ")
            bool isMonthValid = int.TryParse(Console.ReadLine(), out month)

            Console.Write("Enter Year: ")
            bool isYearValid = int.TryParse(Console.ReadLine(), out year)

            if (isDayValid && isMonthValid && isYearValid)
            {
                Console.WriteLine($"Today's date : {day} , {month} , {year}")
                Console.WriteLine($"Today's date : {day} / {month} / {year}")
                Console.WriteLine($"Today's date : {day} – {month} – {year}")
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for day, month, and year.")
            }

            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No
            Console.Write("Enter a number: ")
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine((num % 3 == 0 && num % 4 == 0) ? "Yes" : "No")
            }
            else
            {
                Console.WriteLine("Invalid input.")
            }

            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive
            Console.Write("Enter an integer: ")
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine(num < 0 ? "negative" : "positive")
            }
            else
            {
                Console.WriteLine("Invalid input.")
            }

            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3

            Console.Write("enter first number: ")
            bool isInt1 = int.TryParse(Console.ReadLine(), out int n1)
            Console.Write("enter second number: ")
            bool isInt2 = int.TryParse(Console.ReadLine(), out int n2)
            Console.Write("enter third number: ")
            bool isInt3 = int.TryParse(Console.ReadLine(), out int n3)

            if (isInt1 && isInt2 && isInt3)
            {
                int max = Math.Max(n1, Math.Max(n2, n3))
                int min = Math.Min(n1, Math.Min(n2, n3))
                Console.WriteLine("Max element = " + max)
                Console.WriteLine("Min element = " + min)
            }
            else
            {
                Console.WriteLine("Invalid input.")
            }


            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.




            Console.Write("Enter an integer: ")
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine(num % 2 == 0 ? "Even" : "Odd")
            }
            else
            {
                Console.WriteLine("invalid input.")
            }
            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant
            
            Console.Write("enter a character: ")
            string charInput = Console.ReadLine().ToLower()
            if (charInput.Length > 0 && charInput == "a" || charInput == "e" || charInput == "i" || charInput == "o" || charInput == "u")
            {
                Console.WriteLine("vowel")
            }
            else
            {
                Console.WriteLine("consonant")
            }
            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31

            Console.Write("Enter month number: ")
            if (int.TryParse(Console.ReadLine(), out int monthNum))
            {
                int days
                switch (monthNum)
                {
                    case 2:
                        days = 28
                        break
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        days = 30
                        break
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        days = 31
                        break
                    default:
                        Console.WriteLine("Invalid month number.")
                        return
                }
                Console.WriteLine("Days in Month: " + days)
            }
            else
            {
                Console.WriteLine("Invalid input.")
            }
            #endregion

        }
    }
}
