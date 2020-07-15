using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup11
{
    class Book:Media
    {
      public  int PageCount { get; private set; }

        public Book(int pageCount ,string title, string mediaType) : base(title, mediaType)
        {
           
            PageCount = pageCount;
        }
    }
}
