using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workShop
{
   public class Books
    {
        public int Stock { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int NumOfPages { get; set; }
        public int RentTimes { get; set; }
        //Search filters : title, genre, year, number of pages.
        public Books(int stock, string title, int year, int numOfPages, int rentTimes)
        {
            
        }
    }
}
