using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Page
    {
        static int totalCount;
        static int writtenPages;
        int lineLength;
        int maxLines;
        int currentLine;
        List<Line> lineList;

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
        public static int WrittenPages
        {
            get { return writtenPages; }
            private set
            {
                if (value >= 0)
                    writtenPages = value;
                else
                    throw new ArgumentException("Must be a positive integer");
            }
        }
        public int LineLength
        {
            get { return lineLength; }
            private set
            {
                if (value > 0)
                    lineLength = value;
                else
                    throw new ArgumentException("Must be a positive non-zero integer");
            }
        }
        public int MaxLines
        {
            get { return maxLines; }
            private set
            {
                if (value > 0)
                    maxLines = value;
                else
                    throw new ArgumentException("Must be a positive non-zero integer");
            }
        }
        public int CurrentLine
        {
            get { return currentLine; }
            private set
            {
                if (value >= 0)
                    currentLine = value;
                else
                    throw new ArgumentException("Must be a positive integer");
            }
        }

        static Page()
        {
            TotalCount = 0;
            WrittenPages = 0;
        }
        public Page(int lineLength, int maxLines)
        {
            lineList = new List<Line>();
            LineLength = lineLength;
            MaxLines = maxLines;
            CurrentLine = 0;
            TotalCount++;
        }
        public Page(int lineLength, int maxLines, string text) : this(lineLength, maxLines)
        {
            WriteText(text);
        }

        public string WriteText(string text)
        {
            while (text.Length > 0 && CurrentLine < MaxLines)
            {
                if (CurrentLine == 0)
                    WrittenPages++;
                Line newLine = new Line(LineLength);
                text = newLine.WriteText(text);
                lineList.Add(newLine);
                CurrentLine++;
            }
            return text;
        }

        public static void ResetCounter()
        {
            TotalCount = 0;
        }

        public override string ToString()
        {
            return string.Join("\r\n", lineList);
        }
    }
}
