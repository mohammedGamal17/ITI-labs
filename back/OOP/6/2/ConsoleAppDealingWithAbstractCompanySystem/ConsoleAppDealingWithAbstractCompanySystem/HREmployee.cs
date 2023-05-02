namespace ConsoleAppDealingWithAbstractCompanySystem
{
    internal class HREmployee : Employee
    {

        public HREmployee()
        {

        }

        public HREmployee(uint _id, string _name, uint _salary, Client[] clients) : base(_id, _name, _salary, clients)
        {
            ID = _id;
            Name = _name;
            Salary = _salary;
            Client = clients;
        }


        public string Names { get; set; }
        public override string ShowEmployeeDetails()
        {
            string allClient = "";
            for (int i = 0; i < Client.Length; i++)
            {
                allClient += "♣ " + Client[i].ShowClientDetails() + "\n";
            }
            return $"HR Employee Id: {ID}, Name: {Name}, Salary: {Salary},\nClients:\n{allClient}";
        }


        public static bool operator >=(HREmployee hr1, HREmployee hr2)
        {
            return hr1.Salary >= hr1.Salary;
        }
        public static bool operator <=(HREmployee hr1, HREmployee hr2)
        {
            return hr1.Salary <= hr1.Salary;
        }

        public static bool operator >(HREmployee hr1, HREmployee hr2)
        {
            return hr1.Salary > hr1.Salary;
        }
        public static bool operator <(HREmployee hr1, HREmployee hr2)
        {
            return hr1.Salary < hr1.Salary;
        }
    }
}
