namespace DevAlap_Abstraction
{
    public class PaidUser : IUser
    {
        public void GetContents()
        {
            Console.WriteLine("Contents for Paid Users!");
        }

        public void CancelSubscription() 
        {

        }
    }
}
