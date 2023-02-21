using System;



namespace ConsoleApp3
{
    [Serializable]
    class Employee
    {
        public string emName;
        public int empId;
        [NonSerialized]
        public int empSalary;





        public Employee(int id, string name, int salary)
        {
            this.empId = id;
            this.emName = name;
            this.empSalary = salary;
        }

    }
}

