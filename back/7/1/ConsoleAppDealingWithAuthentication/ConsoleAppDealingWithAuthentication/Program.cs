using System;

namespace ConsoleAppDealingWithAuthentication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1, "Mohammed", "MohammedGamal", "mohammed.gamal.mahmoud7@gmail.com", "12345678");
            Authentication authentication = new Authentication(student);

            Console.WriteLine(authentication.loginMethod(authentication.MyStudent.UserName, authentication.MyStudent.Password));

            Console.WriteLine(authentication.forgetPassword(authentication.MyStudent.UserName));

            Console.WriteLine(authentication.resetPassword(authentication.MyStudent.Email, authentication.MyStudent.Password, "Mo123456789"));

            Console.ReadKey();
        }
    }
}
