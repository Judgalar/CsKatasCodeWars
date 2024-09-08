/*
Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

Example
Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
The returned format must be correct in order to complete this challenge.

Don't forget the space after the closing parentheses!
*/

using System.Text;

namespace kata.kyu6;

public class PhoneNumber
{
    private static readonly int patternLength = 14;

    public static string CreatePhoneNumber(int[] numbers)
    {
        // Validar que el array tiene exactamente 10 elementos
        if (numbers.Length != 10)
        {
            throw new ArgumentException("The array must contain exactly 10 digits.");
        }

        // Validar que todos los números están entre 0 y 9
        if (numbers.Any(n => n < 0 || n > 9))
        {
            throw new ArgumentException("All numbers must be between 0 and 9.");
        }


        StringBuilder sb = new(patternLength);

        int numberIndex = 0;

        while (sb.Length != patternLength )
        {
            sb.Append(sb.Length switch
            {
                0 => '(',
                4 => ") ",
                9 => '-',
                _ => numbers[numberIndex++]

            });
        }

        return sb.ToString();
    }
}