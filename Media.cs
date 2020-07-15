using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup11
{
    abstract class Media
    {
        public string Title { get; private set; }
       static public int SerialNumber { get; private set; } = 0;
       public int TimesLent { get; private set; }
        public string MediaType { get; private set; }
        public string Borrower { get;  set; }
        public Boolean Avalability { get;  set; }

        public Media(string title,string mediaType)
        {
            Title = title;
            SerialNumber++;
            TimesLent = 0;
            MediaType = mediaType;
            Avalability = true;

        }
        
    }
}
