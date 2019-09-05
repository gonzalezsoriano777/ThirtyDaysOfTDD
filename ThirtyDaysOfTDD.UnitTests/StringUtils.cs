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

        }
    }
}
