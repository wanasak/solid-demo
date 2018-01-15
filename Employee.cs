namespace solid_demo
{
    class Employee
    {
        Employee() {}
        public Employee(int id, string name, string employeeType)
        {
            this.ID = ID;
            this.Name = name;
            this.EmployeeType = employeeType;
        }

        public int ID { get; set; } 
        public string EmployeeType { get; set; }
        public string Name { get; set; }

        public decimal CalculateBonus(decimal salary)
        {
            if (this.EmployeeType == "Permanent")
                return salary * .1M;
            else
                return salary * .05M;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
}
