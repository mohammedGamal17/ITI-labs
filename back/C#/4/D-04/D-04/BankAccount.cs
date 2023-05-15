namespace D_04
{
    internal class BankAccount : IComparable<BankAccount>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Salary: {Salary}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType())) return false;


            BankAccount ba = (BankAccount)obj;
            return ID == ba.ID && Name == ba.Name && Salary == ba.Salary;

        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public int CompareTo(BankAccount? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
