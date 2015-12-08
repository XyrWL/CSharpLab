using System;

namespace Lab3
{
    public class Person
    {
        string name;

        public void SetName(string name)
        {
            if (name != null)
                this.name = name;
            else
                throw new ArgumentNullException("name");
        }
        public string GetName()
        {
            return name;
        }
    }
}
