using _02._01_Overriding.Exercise7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._06._01_NewFunctionality
{
    static class MethodExtender
    {
        public static string ToSentence(this string sentence)
        {
            if (string.IsNullOrEmpty(sentence)) return sentence;
            sentence = sentence[0].ToString().ToUpper() + sentence.Substring(1);
            if (sentence[^1] != '.')
            {
                sentence += ".";
            }

            return sentence;
        }

        public static string ToSentence(this string sentence, bool makeDot)
        {
            if (string.IsNullOrEmpty(sentence)) return sentence;
            sentence = sentence[0].ToString().ToUpper() + sentence.Substring(1);
            if (makeDot && sentence[^1] != '.')
            {
                sentence += ".";
            }

            return sentence;
        }

        public static string ToString(this ExtensionEmployee employee, bool showId)
        {
            if (showId)
            {
                return employee.ToString();
                //return $"[{employee.id}] {employee.FirstName} {employee.LastName}";
            }
            return $"{employee.FirstName} {employee.LastName}";
        }

        public static string ToString(this ExtensionEmployee employee)
        {
            return "This extension method has a same signature";
        }
    }
}
