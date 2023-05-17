namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Mohammed");
            Student s2 = new Student(2, "Gamal");
            Student s3 = new Student(3, "Ahmed");
            Student s4 = new Student(4, "Khaled");
            Student s5 = new Student(5, "Tarek");

            //*************************** Department One *********************************//

            Department departOne = new Department(1, "SE");
            departOne.AddStudent(s1);
            departOne.AddStudent(s2);
            departOne.AddStudent(s3);

            s2.setAbsent(2);
            s3.Absentdays = 1;
            s3.Absentdays = 7;
            Console.WriteLine(departOne);
            Console.WriteLine(s3);
            Console.WriteLine("******************************");

            //*************************** Department Two *********************************//
            Department departTwo = new Department(2, "IT");
            departTwo.AddStudent(s4);
            departTwo.AddStudent(s5);

            s4.setAbsent(2);
            s5.Absentdays = 6;
            Console.WriteLine(departTwo);
            Console.WriteLine(s5);

            Console.ReadKey();
        }
    }
}