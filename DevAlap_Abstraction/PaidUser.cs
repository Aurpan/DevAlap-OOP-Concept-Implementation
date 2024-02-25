namespace DevAlap_Abstraction
{
    public class PaidUser: User
    {
        public DateTime LastRenewal { get; set; }
        public DateTime Expiration { get; set; }
    }
}
