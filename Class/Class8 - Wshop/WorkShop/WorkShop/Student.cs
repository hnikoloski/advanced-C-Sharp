using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    public class Student : Person
    {
        public int Id { get; set; }
        public int Points { get; set; }


        public Student(string firstName, string lastName, int id, int points)
        {
            FirstName = firstName;
            LastName = lastName;
            this.Id = id;
            Points = points;
        }

        public void Listen(object source, ExamInfoArgs args)
        {
            if (args.Student.Points > 50)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

    }
    
}
