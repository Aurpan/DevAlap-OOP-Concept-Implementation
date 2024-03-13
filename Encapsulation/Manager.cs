namespace DevAlap_Encapsulation
{
    public class Manager : Employee
    {
        public void GetSalaryData ()
        {
            SalaryPerHour = 500;
            WorkHoursPerDay = 10;

            DoB = DateTime.Now;
        }
    }
}
