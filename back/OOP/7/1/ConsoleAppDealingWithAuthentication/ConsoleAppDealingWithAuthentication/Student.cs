using System;

namespace ConsoleAppDealingWithAuthentication
{
    internal class Student
    {

        public Student(uint _id, string _name, string _username, string _email, string _password)
        {
            ID = _id;
            Name = _name;
            UserName = _username;
            Email = _email;
            Password = _password;
        }



        public uint ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student\nID: {ID}\nName: {Name}\nUsername: {UserName}\nEmail: {Email}\nPassword: {Password}");
        }
    }
}
