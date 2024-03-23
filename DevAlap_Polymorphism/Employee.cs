namespace DevAlap_Polymorphism
{
    public class Employee
    {
        public int BasicSalary { get; set; }

        public Employee()
        {
            BasicSalary = 50000;
        }

        public virtual void GetSalary ()
        {
            Console.WriteLine("This is avg salary for normal employee!");
        }

        public void GetSalary(int empId)
        {
            Console.WriteLine($"This is basic salary for {empId}");
        }

        public void GetSalary(int empId, float bonusAmount)
        {
            float totalSalary = BasicSalary + bonusAmount;

            Console.WriteLine($"This is basic salary for {empId} - {totalSalary}");
        }

        public void GetSalary(int empId, float bonusAmount, 
            float incentiveAmount)
        {
            float totalSalary = BasicSalary + bonusAmount + incentiveAmount;

            Console.WriteLine($"This is basic salary for {empId} - {totalSalary}");
        }
    }
}
