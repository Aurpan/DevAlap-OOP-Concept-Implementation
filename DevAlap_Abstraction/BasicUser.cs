namespace DevAlap_Abstraction
{
    public class BasicUser : IUser
    {
        public void GetContents()
        {
            Console.WriteLine("Contents for Basic Users!");
        }

        public void UpgradeToPaidUser()
        {

        }
    }
}
