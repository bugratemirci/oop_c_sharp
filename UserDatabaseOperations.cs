namespace OOP
{
    public abstract class UserDatabaseOperations : IDatabaseOperations<User> // Soyut Sınıf
    {
        private List<User> users;
        public UserDatabaseOperations()
        {
            users = new List<User>{
                    new User(1, "Kullanıcı 1", "Kullanıcı 1"),
                    new User(2, "Kullanıcı 2", "Kullanıcı 2"),
                    new User(3, "Kullanıcı 3", "Kullanıcı 3")};
        }
        public void Add(User t)
        {
            Console.WriteLine(t.FirstName + " sisteme eklendi.");
        }

        public void Delete(User t)
        {
            Console.WriteLine(t.FirstName + " başarıyla silindi.");
        }
        public void Update(User t)
        {
            Console.WriteLine(t.FirstName + " başarıyla güncellendi.");
        }
        
        public List<User> GetAllData()
        {
            return users;
        }

        public User GetOneData(int id)
        {
            return users.Find(user => user.Id == id);
        }
    }
}