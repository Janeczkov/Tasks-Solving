using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task3
    {
        public static string ArrayChallenge(int[] arr)
        {
            try
            {
                if (arr.Length <= 2)
                {
                    return "-1";
                }
                else
                {
                    int slotsCount = arr[0];
                    List<int> slotsOccupied = arr.Skip(1).ToList();
                    List<Tuple<int, int>> validPairs = new List<Tuple<int, int>>();
                    List<int> slotsFreeToTake = new List<int>();

                    for (int i = 1; i <= slotsCount; i++)
                    {
                        if (!slotsOccupied.Contains(i))
                            slotsFreeToTake.Add(i);
                    }

                    //additional validations:
                    //slots count, slots occupied only positive integers
                    foreach (int i in slotsFreeToTake) //iterate through free slots
                    {
                        for (int j = i + 1; j <= i + 2; j++) //iterate through range of specific slot, for 3 it will be 1,2,3,4,5
                        {
                            if (j != i && j > 0 && j <= slotsCount && slotsFreeToTake.Contains(j)) //do not compare range iterator with same number
                            {
                                if (i % 2 == 0 && i+1 != j) //if even (2,4...) then do not compare even with even+1 (2 and 3) because its cross comparision (check image)
                                {
                                    validPairs.Add(new Tuple<int, int>(i, j));
                                }
                                else if (i % 2 == 1)
                                {
                                    validPairs.Add(new Tuple<int, int>(i, j));
                                }
                            }
                        }
                    }
                    var returnString = string.Join(" | ", validPairs.Select(z => z.Item1 + "," + z.Item2));
                    Console.WriteLine(returnString);

                }

                return "0";


            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
