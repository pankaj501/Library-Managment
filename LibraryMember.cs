using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup11
{
    class LibraryMember
    {
        public string Name { get; private set; }

        public LibraryMember(string name)
        {
            Name = name;
        }
    }
}
