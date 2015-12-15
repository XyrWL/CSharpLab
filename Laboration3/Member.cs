using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Member : Person
    {
        public Instrumenttype Instrument { get; set; }

        public Member(string firstName, string lastName, Instrumenttype instrument) : base(firstName, lastName)
        {
            Instrument = instrument;
        }

        public static bool operator ==(Member first, Member second) => (first.FirstName.ToLower() == second.FirstName.ToLower() && first.LastName.ToLower() == second.LastName.ToLower());
        public static bool operator !=(Member first, Member second) => (first.FirstName.ToLower() != second.FirstName.ToLower() || first.LastName.ToLower() != second.LastName.ToLower());
        public override string ToString() => $"{base.ToString()}, Instrument:{Instrument}";
    }
}
