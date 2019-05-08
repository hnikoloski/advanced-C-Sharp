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
          //register
            string email, password = String.Empty;
            Console.WriteLine("Enter Email");
            email = Console.ReadLine();
            Console.WriteLine("Enter password");
            password = Console.ReadLine();
            var path =
                "C:\\Users\\Hristijan.nikoloski\\Desktop\\Hristijan.Nikoloski\\advancedC#\\Class\\Class13 -Wshop\\file.txt";
            FileInfo userFile = new FileInfo(path);
            using (StreamWriter sw = userFile.CreateText())
            {
             sw.WriteLine("email:" + email);
             sw.WriteLine("password:" + password);
             sw.WriteLine("_____________________");
             sw.Close(); 
            }
            Console.WriteLine("Done");

            //Login
            string email1, password1 = String.Empty;


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
