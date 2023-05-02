namespace ConsoleAppDealingWithAbstractCompanySystem
{
    class Client
    {
        public Client(uint _id, string _name, string _city)
        {
            ID = _id;
            Name = _name;
            City = _city;
        }

        public uint ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public string ShowClientDetails()
        {
            return $"Client Id: {ID}, Name: {Name}, City: {City}";
        }
    }
}
