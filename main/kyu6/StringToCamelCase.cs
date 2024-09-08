/*
Complete the method/function so that it converts dash/underscore delimited words into camel casing. 
The first word within the output should be capitalized only if the original word was capitalized 
(known as Upper Camel Case, also often referred to as Pascal case). The next words should be always capitalized.

Examples
"the-stealth-warrior" gets converted to "theStealthWarrior"

"The_Stealth_Warrior" gets converted to "TheStealthWarrior"

"The_Stealth-Warrior" gets converted to "TheStealthWarrior"
*/

using System.Text;

namespace kata.kyu6;

public class StringToCamelCase
{
    public static string ToCamelCase(string str)
    {
        StringBuilder sb = new();

        bool mayus = false;
        foreach (char c in str)
        {
            if (c == '_' || c == '-')
                mayus = true;
            else
            {
                sb.Append(mayus ? char.ToUpper(c) : c);
                mayus = false;
            }
        }

        return sb.ToString();
    }
}
