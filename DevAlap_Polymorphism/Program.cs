namespace DevAlap_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            // Example of Compile-time Polymorphism - method overloading
            //employee.GetSalary();
            //employee.GetSalary(10);
            //employee.GetSalary(10, 15000);
            //employee.GetSalary(10, 15000, 5000);



            // Example of Runtime Polymorphism - method overriding
            Employee manager = new Manager();

            manager.GetSalary();
        }
    }
}
