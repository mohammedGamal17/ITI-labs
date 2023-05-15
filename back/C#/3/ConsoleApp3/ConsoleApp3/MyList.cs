namespace ConsoleApp3
{
    internal class MyList : List<Person>
    {
        public void Add(Person p)
        {
            string filePath = "D:\\ITI\\Back\\C#\\D-03\\Lab\\ConsoleApp3\\save..txt";
            bool append = true;
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, p.ToString());
            }

            base.Add(p);

        }
    }
}
