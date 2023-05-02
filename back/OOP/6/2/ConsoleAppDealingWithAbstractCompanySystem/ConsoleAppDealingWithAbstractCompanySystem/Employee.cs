namespace ConsoleAppDealingWithAbstractCompanySystem
{
    abstract class Employee
    {
        public Employee()
        {

        }
        public Employee(uint _id, string _name, uint _salary, Client[] clients)
        {
            ID = _id;
            Name = _name;
            Salary = _salary;
            Client = clients;
        }

        public uint ID { get; set; }
        public string Name { get; set; }
        public uint Salary { get; set; }
        public Client[] Client { get; set; }

        public static Employee operator +(Employee hr1, Employee hr2)
        {
            return new HREmployee() { Salary = hr1.Salary + hr2.Salary };
        }
        public abstract string ShowEmployeeDetails();

    }
}
