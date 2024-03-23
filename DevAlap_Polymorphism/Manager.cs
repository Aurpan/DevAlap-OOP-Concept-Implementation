namespace DevAlap_Polymorphism
{
    public class Manager : Employee
    {
        public override void GetSalary()
        {
            Console.WriteLine("This is avg salary for managers!");
        }
    }
}
