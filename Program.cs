namespace LabSex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(14564, 30000, "Tony", "Male"); //object in stack
            Employee employee2 = new Employee(14565, 39000, "Kevin", "Male");
            Employee employee3 = new Employee(14566, 29000, "Anton", "Male");
            Employee employee4 = new Employee(14567, 32500, "Johanna", "Female");
            Employee employee5 = new Employee(14568, 38000, "Anna", "Female");

            Employee employee6 = new Employee(14570, 40000, "Melker", "Male"); //object in list
            Employee employee7 = new Employee(14571, 39000, "Andrea", "Female");
            Employee employee8 = new Employee(14572, 27000, "Ellinor", "Female");
            Employee employee9 = new Employee(14573, 50000, "Johan", "Male");
            Employee employee10 = new Employee(14574, 36000, "Martina", "Female");


            Stack<Employee> employees = new Stack<Employee>();
            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Namn:{employee.Name}. " +
                    $"Kön:{employee.Gender}. " +
                    $"ID nr:{employee.Id}. " +
                    $"Lön:{employee.Salary}kr. ");
            }


            List<Employee> employeesList = new List<Employee>(); //creates list 

            employeesList.Add(employee6); //adds objects to list
            employeesList.Add(employee7);
            employeesList.Add(employee8);
            employeesList.Add(employee9);
            employeesList.Add(employee10);

            if (employeesList.Contains(employee7))
            {
                Console.WriteLine("Employee 7 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee 7 object does not exist in the list.");
            }

            Employee male = employeesList.Find(employee => employee.Gender == "Male");


            if (male != null)
            {
                Console.WriteLine($"Namn:{male.Name}. " +
                    $"Kön:{male.Gender}. " +
                    $"ID nr:{male.Id}. " +
                    $"Lön:{male.Salary}kr. ");
            }
        }
    }
}