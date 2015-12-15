using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Soloartist : Artist
    {
        public Member Member { get; set; }

        public Soloartist(string name, Member member) : base(name)
        {
            Member = member;
        }

        public override string ToString() => $"Name:{Name} Member({Member})";
    }
}
