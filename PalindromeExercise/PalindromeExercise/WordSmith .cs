using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome (string forwardWord)
        {
            bool returnValue = false;
            string backwardsWord = "";

            forwardWord = forwardWord.ToUpper().Replace(" ","");

            var wordLength = forwardWord.Length;
            char[] textarray = forwardWord.ToCharArray();

            for (var i = wordLength-1; i >= 0; i--)
            {
                backwardsWord = backwardsWord + textarray[i];
            }

            if (forwardWord == backwardsWord)
            {
                returnValue = true;
            }

            return returnValue;

        }

    }
}
