using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeStringAlternate
{
    internal class Solution
    {
        private string word1;
        private string word2;

        public Solution(string wordone, string wordtwo) 
        { 
            word1 = wordone;
            word2 = wordtwo;
        
        }

        public String Word1
        {
            get { return word1; }
            set { word1 = value; }
        }

        public String Word2
        {
            get { return word2; }
            set { word2 = value; }
        }

        public string MergeAlternately()
        {

            int lengthCombo = word1.Length + word2.Length;
            string product = "";

            char[] combinedWords = new char[lengthCombo];

            int count = 0;

            for (int i = 0; i < lengthCombo; i++)
            {
                if (i < word1.Length)
                {
                    combinedWords[count++] = word1[i];
                }
                if (i < word2.Length)
                {
                    combinedWords[count++] = word2[i];
                }


            }
            product = new string(combinedWords);
            return product;

        }

        public void display()
        {
            Console.Write("\nInput: word1 = \"" + Word1 +"\", word2 = \"" + Word2 + "\""+
                          "\nOuput: \"" + MergeAlternately() + "\"");
        }

    }
}
