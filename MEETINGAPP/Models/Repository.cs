namespace MEETINGAPP.Models
{

    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() {id=1, Name = "Emin", Email = "abc@gmail.com", Phone = "1111", WillAttend = true });
            _users.Add(new UserInfo() { id = 2, Name = "Aydin", Email = "abcr@gmail.com", Phone = "33333", WillAttend = false });
            _users.Add(new UserInfo() { id = 3, Name = "Sexavet", Email = "abcd@gmail.com", Phone = "2311", WillAttend = true });
        }

        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }

        public static void CreateUsers(UserInfo user)
        {
            user.id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.id == id);
        }
    }

}

