namespace DevAlap_OOP
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private DateTime DoB { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Password { get; set; }


        public void UserLogin ()
        {
            Console.WriteLine("User logged in");
            //Console.WriteLine($"Hello {FirstName}, welcome");
        }

        public void UserLogout()
        {
            //Console.WriteLine($"Goodbye {FirstName}");
            Console.WriteLine("User logged out");
        }

    }
}
