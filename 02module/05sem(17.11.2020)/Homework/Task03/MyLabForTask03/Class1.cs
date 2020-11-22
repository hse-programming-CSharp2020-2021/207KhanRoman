using System;

namespace MyLabForTask03
{
    public class Employee
    {
        public string name;
        protected decimal basepay;

        public Employee(string name, decimal basepay)
        {
            this.name = name;
            this.basepay = basepay;
        }

        public virtual decimal CalculatePay()
        {
            return basepay;
        }
    }

    public class SalesEmployee : Employee
    {
        private decimal salesbonus;

        public SalesEmployee(string name, decimal basepay,
                  decimal salesbonus) : base(name, basepay)
        {
            this.salesbonus = salesbonus;
        }
        public override decimal CalculatePay()
        {
            return basepay + salesbonus;
        }
    }
    public class PartTimeEmployee : Employee
    {
        int workingDays;
        public PartTimeEmployee(string name, decimal basepay, int workdays) :base(name,basepay)
        {
            workingDays = workdays;
        }
        public override decimal CalculatePay()
        {
            return basepay/25*workingDays;
        }
    }
}
