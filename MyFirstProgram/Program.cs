using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            String fullName = "Bro Code";
            String phoneNumber = "123-465-7890";

            //fullName.ToUpper();
            //fullName.ToLower();
            //Console.WriteLine(fullName);

            //phoneNumber = phoneNumber.Replace("-", "/");
            //Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0, "@");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length);

            // index to start then how many characters to slice;
            //String firstName = fullName.Substring(0, 3);
            //Console.WriteLine(firstName);

            String lastName = fullName.Substring(4, 4);
            Console.WriteLine(lastName);

            Console.Beep();
            Console.ReadKey();
            
        } 
    }
}