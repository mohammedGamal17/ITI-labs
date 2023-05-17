namespace School
{
    internal class Student
    {
        private int absent;

        public int ID { get; set; }
        public string Name { get; set; }

        public event Action<Student> StudentFired;
        public Student(int _id, string _name)
        {
            ID = _id;
            Name = _name;
        }

        public int Absentdays
        {
            get
            {
                return absent;
            }
            set
            {
                absent = value;
                if (absent >= 5)
                {
                    StudentFired.Invoke(this);
                }
            }
        }

        public void setAbsent(int x)
        {
            absent += x;
            if (absent >= 5)
            {
                StudentFired.Invoke(this);
            }
        }

        public override string ToString()
        {
            return $"ID: {ID},\tName: {Name},\tAbsent: {Absentdays}";
        }
    }
}
