using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {

        }

    public bool isAPalindrome(string input)
        {
            int length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (char.ToLower(input[i]) != char.ToLower(input[length - i - 1]))
                    return false;
            }
            return true;
        }
    }
}

