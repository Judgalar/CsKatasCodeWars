/*
 * Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

    Examples:

    solution('abc', 'bc') // returns true
    solution('abc', 'd') // returns false
*/

namespace kata.kyu7;

public class StringEndWith
{
    public static bool Solution(string str, string ending)
    {
        int j = str.Length-1;
        for (int i = ending.Length-1; i >= 0; i--, j--)
        {
            if (j == -1)
                return false;
            if(ending[i] != str[j])
                return false;
        }

        return true;
    }
}