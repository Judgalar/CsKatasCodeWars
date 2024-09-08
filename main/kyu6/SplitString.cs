/*
Complete the solution so that it splits the string into pairs of two characters. 
If the string contains an odd number of characters then it should replace the missing second character of the final pair  with an underscore ('_').

Examples:
    * 'abc' =>  ['ab', 'c_']
    * 'abcdef' => ['ab', 'cd', 'ef']
*/

using System.Text;

namespace kata.kyu6;

public class SplitString
{
    public static string[] Solution(string str)
    {
        string s = (str.Length % 2 == 0) ? str : str + "_";

        string[] resul = new string[s.Length/2];

        int j = 0;
        for (int i = 0; i < s.Length;)
        {
            resul[j++] = s[i++].ToString() + s[i++].ToString();
        }

        return resul;
    }
}

