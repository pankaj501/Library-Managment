using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup11
{
    class Movie:Media
    {
        public Double RunTime { get; private set; }
        public Movie(Double runTime, string title, string mediaType) : base( title, mediaType)
        {
            RunTime = runTime;
        }
    }
}
