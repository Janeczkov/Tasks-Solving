using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task1
    {
        public static string StringChallenge(string str)
        {
            try
            {
                char[] strArr = str.ToCharArray();

                var chars = new List<CharData>();
                foreach (char c in strArr)
                {
                    if (chars.Count > 0)
                    {
                        if (chars.ToArray()[chars.Count - 1].CharValue == c)
                        {
                            chars.Last(z => z.CharValue == c).IntValue += 1;
                        }
                        else
                        {
                            chars.Add(new CharData(c, 1));
                        }
                    }
                    else
                    {
                        chars.Add(new CharData(c, 1));
                    }
                }

                string returnString = "";

                foreach (var a in chars)
                {
                    returnString += a.IntValue + a.CharValue.ToString();
                }

                return returnString;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public class CharData
        {
            public CharData(char charValue, int intValue)
            {
                CharValue = charValue;
                IntValue = intValue;
            }

            public char CharValue { get; set; }
            public int IntValue { get; set; }
        }
    }
}
