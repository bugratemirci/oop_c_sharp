namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            UserOperations userOperations = new UserOperations(); // Nesne

            List<User> users = new List<User>();
            User user = new User();

            users = userOperations.GetAllData();
            users.ForEach(user => Console.WriteLine(user.FirstName));

            user = userOperations.GetOneData(1);
            user = userOperations.GetOneDataByLastName("Kullanıc 1");
            
            Console.WriteLine(user.FirstName);
        }
    }
}