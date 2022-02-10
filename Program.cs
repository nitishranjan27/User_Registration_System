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
            //UC3
            CheckEmail email = new CheckEmail();
            Console.WriteLine("Please Enter your email to check");
            var check3 = email.ValidateEMail(Console.ReadLine());
            Console.WriteLine(check3);
            //UC4
            MobileFormate mobile = new MobileFormate();
            Console.WriteLine("Please Enter your mobile no with country code");
            var check4 = mobile.ValidateMobileNo(Console.ReadLine());
            Console.WriteLine(check4);
            //UC5
            Password1_Min8Char password1 = new Password1_Min8Char();
            Console.WriteLine("Please Enter your password to check");
            var check5 = password1.ValidatePassword1(Console.ReadLine());
            Console.WriteLine(check5);
            //UC6
            Password2_AtLeastOneUpperCase password2 = new Password2_AtLeastOneUpperCase();
            Console.WriteLine("Please Enter your password to check");
            var check6 = password2.ValidatePassword2(Console.ReadLine());
            Console.WriteLine(check6);
            //UC7
            Password3_AtLeastOneNumericNumber password3 = new Password3_AtLeastOneNumericNumber();
            Console.WriteLine("Please Enter your password to check");
            var check7 = password3.ValidatePassword3(Console.ReadLine());
            Console.WriteLine(check7);
        }
    }
}
