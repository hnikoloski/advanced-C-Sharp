using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    public class Trainer : Person
    {
        public Trainer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public delegate void ResultHandler(object points, ExamInfoArgs args);
        public event ResultHandler Results;

        protected virtual void Announce()
        {
            //check if there are sunscribers
            Results?.Invoke(this, new ExamInfoArgs() { });
        }

    }

    public class ExamInfoArgs : EventArgs
    {
        public Student Student { get; set; }
        public int Points { get; set; }
    }

}
