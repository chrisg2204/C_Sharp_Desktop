namespace Model
{
    public class User
    {
        private string name;
        private string passwd;
        private string email;
        private string profile;

        public string Name { get { return name; } set { name = value; } }
        public string Passwd { get { return passwd; } set { passwd = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Profile { get { return profile; } set { profile = value; } }
    }
}
