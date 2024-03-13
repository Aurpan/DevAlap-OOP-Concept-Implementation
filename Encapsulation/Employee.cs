namespace DevAlap_Encapsulation
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        internal DateTime DoB { get; set; }

        protected float SalaryPerHour { get; set; }
        protected int WorkHoursPerDay { get; set; }


        public Employee()
        {
            WorkHoursPerDay = 8;
            SalaryPerHour = 200;
        }


        public float GetMonthlySalary ()
        {
            return GetSalaryByDays(30, 100);
        }

        public float GetAnnualSalary()
        {
            return GetSalaryByDays(365, 2000);
        }

        private float GetSalaryByDays (int numberOfDays, float bonusAmount)
        {
            float basicSalary = SalaryPerHour * WorkHoursPerDay * numberOfDays;

            return basicSalary + bonusAmount;
        }

    }
}
