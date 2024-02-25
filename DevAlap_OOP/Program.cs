using DevAlap_OOP;

namespace DevAlap_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PaidUser paidUser = new PaidUser();

            //paidUser.UserLogin();
            //paidUser.UserLogout();

            AdminUser admin = new AdminUser();

            admin.UserLogin();
            admin.GetPaidContents();
            admin.UserLogout();

            User user = new User();

            

        }
    }
}
