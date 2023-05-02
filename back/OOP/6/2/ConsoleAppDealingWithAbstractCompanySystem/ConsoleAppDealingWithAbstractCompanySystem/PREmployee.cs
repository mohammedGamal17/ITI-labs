namespace ConsoleAppDealingWithAbstractCompanySystem
{
    internal class PREmployee : Employee
    {
        public PREmployee(uint _id, string _name, uint _salary, Client[] clients) : base(_id, _name, _salary, clients)
        {
            ID = _id;
            Name = _name;
            Salary = _salary;
            Client = clients;
        }

        public override string ShowEmployeeDetails()
        {
            string allClient = "";
            for (int i = 0; i < Client.Length; i++)
            {
                allClient += "♣ " + Client[i].ShowClientDetails() + "\n";
            }
            return $"PR Employee Id: {ID}, Name: {Name}, Salary: {Salary},\nClients\n{allClient}";
        }
    }
}
