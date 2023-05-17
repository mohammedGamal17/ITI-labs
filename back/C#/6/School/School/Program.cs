namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Mohammed");
            Student s2 = new Student(2, "Gamal");
            Student s3 = new Student(3, "Ahmed");

            Department Dep1 = new Department(1, "dep1");
            Dep1.AddStudent(s1);
            Dep1.AddStudent(s2);
            Dep1.AddStudent(s3);

            Console.WriteLine(Dep1);
            Console.WriteLine("*************************");
            s2.setAbsent(2);
            s3.Absentdays = 1;
            s3.Absentdays = 7;
            Console.WriteLine(Dep1);
            Console.WriteLine("*************************");
            Console.WriteLine(s3);

            Console.ReadKey();
        }
    }
}