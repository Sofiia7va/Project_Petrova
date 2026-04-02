using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public static class StringExtensions
    {
        // Метод підрахунку слів у рядку
        public static int WordCount(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            string[] words = text.Split(' ');
            return words.Length;
        }
    }
}
