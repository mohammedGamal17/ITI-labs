namespace SchoolTest.Serves
{
    public interface IServies<T> where T : class
    {
        public Task<List<T>> GetAll();
        public Task<T> Details(int id);
        public Task<T> Create(T T);
        public Task<T> Find(int? id);
        public Task<T> Edit(T t);
        public Task<T> Delete(int id);
        public void DeleteConfirmed(T t);

        public bool EntityExists(int id);
    }


}
