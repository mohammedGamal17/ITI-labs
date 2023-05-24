namespace DataBasinessLayer
{
    public class Student
    {
        #region Constructors
        public Student(int _id, string _name, int _age, int _departmentID)
        {
            ID = _id;
            Name = _name;
            Age = _age;
            DepartmentID = _departmentID;
        }
        public Student()
        {

        }
        #endregion

        #region PROP
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int DepartmentID { get; set; }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Department ID: {DepartmentID}";
        }
        #endregion

    }
}
