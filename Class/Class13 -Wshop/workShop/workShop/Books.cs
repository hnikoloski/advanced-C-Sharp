using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workShop
{
   public class Books
    {
        public int stock { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public int numOfPages { get; set; }
        public int rentTimes { get; set; }
        //Search filters : title, genre, year, number of pages.

    }
}
