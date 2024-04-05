

namespace OOP
{
    public interface IManage
    {
        void Add(object obj);
    }
    public class Employee
    {
        //fields
        private string id;
        private string name;
        private string dob;

        //properties => Encapsulation
        public string ID { get => this.id; set => this.id = value;}
        public string Name {get => this.name; set => this.name = value;}
        public string Dob {get => this.dob; set => this.dob = value;}

        //constructor
        public Employee(string id, string name, string dob)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
        }

        //override method
        public override string ToString()
        {
            return $"Employer: {this.id} - Name: {this.name} - DOB: {this.dob}";
        }
    }
    public class Department : Employee
    {
        private string departmentName;
        public string DepartmentName {get => this.departmentName; set => this.departmentName = value;}

        public Department(string id, string name, string dob, string departmentName) : base(id, name,dob)
        {
            this.departmentName = departmentName;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Department Name: {departmentName}";
        }

    }

    public class EmployeeManage : IManage
    {
        //field
        private List<object> employeeList;

        //constructor
        public EmployeeManage()
        {
            employeeList = new List<object>();
        }
        public void getAllEmp()
        {
            if(employeeList.Count != 0)
            {
                foreach(var e in employeeList)
            {
                 Console.WriteLine(e.ToString());
            }
            }
            else Console.WriteLine("There's no employee in this list");
            
        }
        public void Add(object obj){
            employeeList.Add(obj);
        }
    }
    class Program{
         static void Main(string[] args)
        {
            Employee e1 = new Employee("1", "John Cena", "1999");
            Employee e2 = new Employee("2", "The Rock", "2000");
            Employee e3 = new Employee("3", "Mc Gregor", "2001");
            Employee e4 = new Employee("4", "Khalib", "1980");

            Console.WriteLine(e1.ToString());

            Department IT = new Department("5", "Nghia", "2002", "IT");
            Console.WriteLine(IT.ToString());

            EmployeeManage EmpList = new EmployeeManage();
            EmpList.Add(e1);
            EmpList.Add(e2);
            EmpList.Add(e3);
            EmpList.Add(e4);

            EmpList.getAllEmp();
        }
    }
   
}
