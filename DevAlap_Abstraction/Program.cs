namespace DevAlap_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "AurGha";

            //name.ToUpper();
            //name.Substring(0, name.Length - 1);

            IUser userBasic = new BasicUser();
            IUser userPaid = new PaidUser();
            IUser userGuest = new GuestUser();

            userBasic.GetContents();
            userPaid.GetContents();

        }
    }
}
