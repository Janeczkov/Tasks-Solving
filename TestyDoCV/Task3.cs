using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyDoCV
{
    public class Task3
    {
        public static string StringChallenge(string str)
        {
            try
            {
                char[] strArr = str.ToCharArray();

                int j = strArr.Length-1;
                bool skippedLetter = false;
                string skippedLetters = "";
                //int indexOfLastPalindromeMatch = 0;
                int numberOfSkippedLetters = 0;
                bool loopBreaked = false;
                for (int i=0; i < j; i++)
                {
                    if (strArr[i] != strArr[j])
                    {
                        if (numberOfSkippedLetters >= 2)
                        {
                            //i = Math.Max(indexOfLastPalindromeMatch - 1, 0);
                            loopBreaked = true;
                            break;
                        }
                        else
                        {
                            if (numberOfSkippedLetters == 0)
                            {
                                //indexOfLastPalindromeMatch = i;
                            }
                            numberOfSkippedLetters++;
                            skippedLetter = true;
                            skippedLetters += strArr[i].ToString();
                        }
                    }
                    if (!skippedLetter)
                    {
                        j--;// strArr.Length - 1 - 1;
                    }
                    skippedLetter = false;
                }
                if (loopBreaked)
                {
                    return "not possible";
                }
                else
                {
                    if (skippedLetters == "")
                    {
                        return "palindrome";
                    }
                    return skippedLetters;
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
