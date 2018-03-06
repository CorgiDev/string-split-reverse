using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplit
{
    public class Class1
    {
        public string SplitString(string input)
        {
            string reversedPhrase ="";
            string phrase = "The cat goes";
            string[] words = phrase.Split(' ');
            foreach (string word in words)
            {
                string reversedWord = new string(word.Reverse().ToArray());
                reversedPhrase += reversedWord;
                reversedPhrase += " ";
            }
            //Return the array back to a string.
            return reversedPhrase.Trim();
        }
    }
}
