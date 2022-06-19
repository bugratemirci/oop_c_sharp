namespace OOP
{
    public class User // Sınıf
    {

        private int _id;
        private string _firstName;
        private string _lastName;
        public User()
        {

        }
        public User(int id, string firstName, string lastName)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
        }


        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public int Id { get => _id; set => _id = value; }


    }
}