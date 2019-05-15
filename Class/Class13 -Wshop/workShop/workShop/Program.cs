using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workShop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Books
            var book1 = new Books(5,"title1",1999,500,5);
            var book2 = new Books(6,"title2",1998,400,5);
            var book3 = new Books(7,"title3",1997,600,5);
            var book4 = new Books(8,"title4",1996,700,5);
            var book5 = new Books(9,"title5",1995,800,5);
            var book6 = new Books(10,"title6",1994,900,5);
            var book7 = new Books(2,"title7",1993,200,5);
            var book8 = new Books(1,"title8",1992,100,5);
            var book9 = new Books(3,"title9",1991,50,5);
            var book10 = new Books(6, "title10", 1990, 1, 5);



            #endregion

            #region Users

            var supplier = new Users("supplier", "supplier", "supplier");
            var librarian = new Users("librarian", "librarian", "librarian");
            var member = new Users("member", "member", "member");

            #endregion


            string email = string.Empty;
            string password = string.Empty;
            bool loginCheck = false;

         
            //cekicmiodrag@gmail.com 123Miki
            //CekicMiodrag@gmail.com 123miki   

            while (loginCheck == false)
            {
                Console.WriteLine("Enter your email");
                email = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter your password");
                password = Console.ReadLine();
                Console.Clear();
                if (!email.Trim().ToLower().Equals(Users.Email.Trim().ToLower()) && password != Users.Password))
                {
                    loginCheck = false;
                    Console.WriteLine(" invalid login");
                }
                else
                {
                    loginCheck = true;
                    
                }
            }
            Console.WriteLine("Loged in");


            #region LoginAtempts
            //int loginAttempts = 0;
            //int maxLoginAttepmts = 3;
            //for (int i = 0; i < maxLoginAttepmts; i++)
            //{
            //    Console.WriteLine("Enter email");
            //    var loginEmail = Console.ReadLine();
            //    Console.WriteLine("Enter password");
            //    var logiinPassword = Console.ReadLine();

            //    if (loginEmail != email || logiinPassword != "123")
            //    {
            //        Console.WriteLine($"Invalid Info. \n Attempt {loginAttempts + 1} / {maxLoginAttepmts}\n");
            //        loginAttempts++;
            //    }
            //    else
            //        break;
            //}

            //if (loginAttempts > maxLoginAttepmts - 1)
            //    Console.WriteLine("Login failure");
            //else
            //    Console.WriteLine("Login successful");


            #endregion


            Console.ReadLine();

        }
    }
}
