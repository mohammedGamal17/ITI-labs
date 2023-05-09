namespace Bank.Interfaces
{
    internal class Clone : ICloneable
    {
        public int ID { get; set; }
        public string Name { get; set; }

        object ICloneable.Clone()
        {
            return new Clone
            {
                ID = this.ID,
                Name = this.Name
            };
        }

        public override string ToString()
        {
            return "ID: " + ID + "\nName: " + Name;
        }
    }
}
