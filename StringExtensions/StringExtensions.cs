using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] {' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string CapitalizeFirst(this String str)
        {
            string first = str[0].ToString().ToUpper();
            return first + str.Substring(1);
        }

        public static void Decapitalize(this String str)
        {
            string first = str[0].ToString().ToUpper();
            str =  first + str.Substring(1);
        }

        public static string Titleize(this String title)
        {
            List<string> parts = new List<string>(.Split(" "));
            List<string> articles = new List<string>() { "the", "and", "a" };
            string first = parts[0];
            parts.RemoveAt(0);
            parts.Add(", ");
            parts.Add(first);
            while (articles.Contains(first.ToLower()))
            {
                parts.RemoveAt(0);
                parts.Add(first);
                first = parts[0];
            }

            return parts.ToString();

        }
    }
}
