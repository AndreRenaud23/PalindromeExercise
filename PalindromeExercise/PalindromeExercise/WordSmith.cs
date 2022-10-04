using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string strInput)
        {


            var length = strInput.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (strInput[i] != strInput[length - i - 1])
                {
                    return false;
                };
            }
            return true;
            

        }
    }
}
