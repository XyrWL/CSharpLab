using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Word
    {
        static int totalCount;
        string content;

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
        public string Content
        {
            get { return content; }
            private set
            {
                if (value != null)
                    content = value;
                else
                    throw new ArgumentNullException();
            }
        }
        
        static Word()
        {
            TotalCount = 0;
        }
        public Word(string content)
        {
            Content = content;
            TotalCount++;
        }

        public static void ResetCounter()
        {
            TotalCount = 0;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
