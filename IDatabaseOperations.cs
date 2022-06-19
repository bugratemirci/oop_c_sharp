namespace OOP
{
    public interface IDatabaseOperations<T> // Interface
    {
        public void Add(T t);
        public void Update(T t);
        public void Delete(T t);
        public T GetOneData(int id);
        public List<T> GetAllData();

    }
}