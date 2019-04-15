using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Trainers & Students
            //Trainers
            var trainer1 = new Trainer("Miodrag", "Cekic");

            //Students
            var students1 = new Student("Hristijan", "Nikoloski", 123, 90);
            var students2 = new Student("Hristijan", "Nikoloski", 123, 60);
            var students3 = new Student("Hristijan", "Nikoloski", 123, 50);
            var students4 = new Student("Hristijan", "Nikoloski", 123, 20);

            #endregion

            //Trainer.ResultHandler += students1.Listen;


            
            Console.ReadKey();

        }
    }
}
