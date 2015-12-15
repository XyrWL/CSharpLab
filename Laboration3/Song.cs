using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    struct Song
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public static bool operator ==(Song first, Song second) => (first.Name.ToLower() == second.Name.ToLower());
        public static bool operator !=(Song first, Song second) => (first.Name.ToLower() != second.Name.ToLower());
        public override string ToString() => $"Name:{Name}, Duration:{Duration}";
    }
}
