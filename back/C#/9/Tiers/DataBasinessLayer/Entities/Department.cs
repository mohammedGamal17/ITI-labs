namespace DataBasinessLayer
{
    public class Department
    {
        #region Fields
        int capacity;
        #endregion

        #region Constructors
        public Department(int _id, string _name, int _capacity)
        {
            ID = _id;
            Name = _name;
            Capacity = _capacity;
        }

        public Department()
        {
            Name = "N/A";
            Capacity = -1;
        }
        #endregion

        #region PROP
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (capacity > 30) capacity = 30;
                else capacity = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Capacity: {Capacity}";
        }
        #endregion
    }
}
