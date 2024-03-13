namespace DevAlap_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            var salary = employee.GetMonthlySalary();

            employee.DoB = DateTime.Now;

        }
    }
}
