namespace DevAlap_Abstraction
{
    public class GuestUser : IUser
    {
        public void GetContents()
        {
            Console.WriteLine("Contents for Guest Users!");
        }

        public void Register ()
        {

        }
    }
}
