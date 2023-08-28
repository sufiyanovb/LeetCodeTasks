using System.Text.RegularExpressions;
using System.Text;

namespace LeetCodeTasks
{
    public class Solution
    {
        public string Convert(string s, int numRows)//6. Zigzag Conversion
        {
            if (!Regex.IsMatch(s, @"^[a-zA-Z.,]{1,1000}$")) { return ""; }

            if (numRows == 1) { return s; }

            var analyzedData = new char[((s.Length / 2) + (s.Length % 2)), numRows];

            var sb = new StringBuilder(s.Length);

            var currIndexInStr = 0;

            var lastCol = 0;

            for (int i = 0; i < analyzedData.GetLength(0); i++)
            {
                for (int j = 0; j < analyzedData.GetLength(1); j++)
                {
                    if (i % (numRows - 1) != 0)
                    {
                        lastCol--;
                        analyzedData[i, lastCol] = currIndexInStr > s.Length - 1 ? '\0' : s[currIndexInStr]; ;
                        currIndexInStr++;
                        break;
                    }

                    analyzedData[i, j] = currIndexInStr > s.Length - 1 ? '\0' : s[currIndexInStr];
                    lastCol = j;
                    currIndexInStr++;
                }
            }
            for (int j = 0; j < analyzedData.GetLength(1); j++)
            {
                for (int i = 0; i < analyzedData.GetLength(0); i++)
                {
                    if (analyzedData[i, j] == '\0') { continue; }

                    sb.Append(analyzedData[i, j]);
                }
            }
            return sb.ToString();
        }
    }
}