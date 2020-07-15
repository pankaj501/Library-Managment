using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup11
{
    class Magazine:Book
    {
        public int IssueNumber { get; private set; }

        public Magazine(int pageCount, string title, string mediaType):base(pageCount,title,mediaType)
        {
            //issueNumber = IssueNumber;
        }

    }
}
