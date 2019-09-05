using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysOfTDD.UnitTests
{
    public class StringUtils
    {
        public int FindNumberOfOccurences(string sentenceToScan, string characterToScanFor)
        {
            var stringToCheckAsCharacterArray = sentenceToScan.ToCharArray();

            var characterToCheckFor = Char.Parse(characterToScanFor);

            int numberOfOccurences = 0;

            for(int charIdx = 0; charIdx < stringToCheckAsCharacterArray.GetUpperBound(0); charIdx++)
            {
                if (stringToCheckAsCharacterArray[charIdx] == characterToCheckFor)
                {
                    numberOfOccurences++;
                }
            }

            return numberOfOccurences;

        }
    }
}
