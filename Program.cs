using System;

namespace User_Registration_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            FirstName firstName = new FirstName(); ;
            Console.WriteLine("Please Enter your first name");
            var check = firstName.ValidateFirstName(Console.ReadLine());
            Console.WriteLine(check);
            //UC2
            LastName lastName = new LastName();
            Console.WriteLine("Please Enter your last name");
            var check2 = lastName.ValidateFirstName(Console.ReadLine());
            Console.WriteLine(check2);
        }
    }
}
