namespace DevAlap_OOP
{
    public class PaidUser : User
    {
        public DateTime LastRenewal { get; set; }
        public DateTime Expiration { get; set; }
        public string FirstName { get; set; }



        public void GetPaidContents ()
        {
            FirstName = "Aurgha-2";
            base.FirstName = "Aurgha-1";
            LastName = "Dash";

            Email = "adad";
            Password = "Password";
            //DoB = DateTime.Now;
            Console.WriteLine("These are paid contents");
        }

    }
}
