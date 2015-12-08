using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Line
    {
        static int totalCount;
        int maxLength;
        int currentLength;
        List<Word> wordList;

        public static int TotalCount
        {
            get { return totalCount; }
            private set
            {
                if (value >= 0)
                    totalCount = value;
                else
                    throw new ArgumentException("Must be a positive integer");
            }
        }
        public int MaxLength
        {
            get { return maxLength; }
            private set
            {
                if (value > 0)
                    maxLength = value;
                else
                    throw new ArgumentException("Must be a positive non-zero integer");
            }
        }
        public int CurrentLength
        {
            get { return currentLength; }
            private set
            {
                if (value >= 0)
                    currentLength = value;
                else
                    throw new ArgumentException("Must be a positive integer");
            }
        }

        static Line()
        {
            TotalCount = 0;
        }
        public Line(int maxLength)
        {
            wordList = new List<Word>();
            MaxLength = maxLength;
            CurrentLength = 0;
            TotalCount++;
        }
        public Line(int maxLength, string text) : this(maxLength)
        {
            WriteText(text);
        }

        public string WriteText(string text)
        {
            string[] wordArray = text.Split(' ');
            string remainingText = "";

            for (int i = 0; i < wordArray.Length; i++)
            {
                if ((wordArray[i].Length + 1) + CurrentLength <= MaxLength + 1)
                {
                    wordList.Add(new Word(wordArray[i]));
                    CurrentLength += wordArray[i].Length + 1;
                }
                else
                {
                    remainingText = string.Join(" ", wordArray.Skip(i));
                    break;
                }
            }
            return remainingText;
        }

        public static void ResetCounter()
        {
            TotalCount = 0;
        }

        public override string ToString()
        {
            return string.Join(" ", wordList);
        }
    }
}
