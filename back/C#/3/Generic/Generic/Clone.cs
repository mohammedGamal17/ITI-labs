namespace Generic
{
    public class CloneClass : ICloneable
    {

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }



        public CloneClass(int _id)
        {
            ID = _id;
        }

        public object Clone()
        {
            return new CloneClass(ID);
        }
    }

}
