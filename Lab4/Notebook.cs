using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Notebook
    {
        Page[] pages;
        int numberOfPages;
        double width;
        double height;
        double fontWidth;
        double lineHeight;

        public Page this[int index]
        {
            get
            {
                if (index >= 0 && index < pages.Length)
                    return pages[index];
                else
                    throw new ArgumentOutOfRangeException();
            }
            private set
            {
                if (index >= 0 && index < pages.Length)
                {
                    if (value != null)
                        pages[index] = value;
                    else
                        throw new ArgumentNullException();
                }
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        public int Length
        {
            get { return pages.Length; }
        }
        public int NumberOfPages
        {
            get { return numberOfPages; }
            private set
            {
                if (value > 0)
                    numberOfPages = value;
                else
                    throw new ArgumentException("Must be a positive non-zero integer");
            }
        }
        public double Width
        {
            get { return width; }
            private set
            {
                if (value > 0)
                    width = value;
                else
                    throw new ArgumentException("Must be a positive non-zero value");
            }
        }
        public double Height
        {
            get { return height; }
            private set
            {
                if (value > 0)
                    height = value;
                else
                    throw new ArgumentException("Must be a positive non-zero value");
            }
        }
        public double FontWidth
        {
            get { return fontWidth; }
            private set
            {
                if (value > 0)
                    fontWidth = value;
                else
                    throw new ArgumentException("Must be a positive non-zero value");
            }
        }
        public double LineHeight
        {
            get { return lineHeight; }
            private set
            {
                if (value > 0)
                    lineHeight = value;
                else
                    throw new ArgumentException("Must be a positive non-zero value");
            }
        }
                
        public Notebook(int numberOfPages, double width, double height, double fontWidth, double lineHeight, string text = "")
        {
            NumberOfPages = numberOfPages;
            Width = width;
            Height = height;
            FontWidth = fontWidth;
            LineHeight = lineHeight;
            CreateNotebookPages();
            if (text.Length > 0)
                WriteText(text);
        }
        public Notebook(int numberOfPages, double width, double height, string text = "") : this(numberOfPages, width, height, fontWidth: 0.49, lineHeight: 0.9, text: text) { }
        public Notebook(int numberOfPages, string text = "") : this(numberOfPages, width: 21.0, height: 29.7, text: text) { }

        private void CreateNotebookPages()
        {
            int lineLength = (int)(Math.Floor(Width / FontWidth));
            int maxLines = (int)(Math.Floor(Height / LineHeight));

            pages = new Page[NumberOfPages];
            for (int i = 0; i < pages.Length; i++)
            {
                pages[i] = new Page(lineLength, maxLines);
            }
        }
        public string WriteText(string text)
        {
            for (int i = 0; i < pages.Length; i++)
            {
                text = pages[i].WriteText(text);
            }
            return text;
        }

        public override string ToString()
        {
            return $"Notebook(NumberOfPages:{NumberOfPages}, Width:{Width}, Height:{Height}, FontWidth:{FontWidth}, LineHeight:{LineHeight})";
        }
    }
}
