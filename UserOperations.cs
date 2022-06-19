namespace OOP
{
    public class UserOperations : UserDatabaseOperations // Sınıf
    {
        public User GetOneDataByLastName(string lastName)
        {
            return base.GetAllData().Find(user => user.LastName == lastName);
        }
    }
}