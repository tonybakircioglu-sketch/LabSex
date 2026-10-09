namespace LabSex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(14564, 30000, "Tony", "Male"); //creates objects with Employee class
            Employee employee2 = new Employee(14565, 39000, "Kevin", "Male");
            Employee employee3 = new Employee(14566, 29000, "Anton", "Male");
            Employee employee4 = new Employee(14567, 32500, "Johanna", "Female");
            Employee employee5 = new Employee(14568, 38000, "Anna", "Female");

            Employee employee6 = new Employee(14570, 40000, "Melker", "Male"); //object in list
            Employee employee7 = new Employee(14571, 39000, "Andrea", "Female");
            Employee employee8 = new Employee(14572, 27000, "Ellinor", "Female");
            Employee employee9 = new Employee(14573, 50000, "Johan", "Male");
            Employee employee10 = new Employee(14574, 36000, "Martina", "Female");




            Stack<Employee> employees = new Stack<Employee>(); // Creates stack named employees 
            employees.Push(employee1); // Places object in stack
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            Console.WriteLine("LAB 6: OOP GENERIC COLLECTIONS" +
                            "\n--------------------------------------------------------");


            foreach (Employee employee in employees)  // Prints values "foreach" object in the group. 

                Console.WriteLine($"Items left in stack: {employees.Count}\n" + // prints current amount of objects in stack
                    $"Name:{employee.Name} - " +
                    $"Gender:{employee.Gender} - " +
                    $"ID:{employee.Id} - " +
                    $"Salary:{employee.Salary}kr\n");


            Console.WriteLine("--------------------------------------------------------" +
                "\nRetrive using pop method");

            while (employees.Count > 0) // Loops through until stack is empty 
            {
                Employee employee = employees.Pop(); //returns last object before it removes it from the stack

                Console.WriteLine(
                  $"\nName:{employee.Name} - " +
                  $" Gender:{employee.Gender} - " +
                  $" ID:{employee.Id} - " +
                  $" Salary:{employee.Salary}kr - " +
                  $" Items left in stack: {employees.Count}\n");


            }


            employees.Push(employee1); // Places object in stack
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            Console.WriteLine("--------------------------------------------------------" +
            "\nRetrive using peek method.");

            Employee topEmployee = employees.Peek();

            Console.WriteLine(
                 $"\nName:{topEmployee.Name} - " +
                 $" Gender:{topEmployee.Gender} - " +
                 $" ID:{topEmployee.Id} - " +
                 $" Salary:{topEmployee.Salary}kr - " +
                 $" Items left in stack: {employees.Count}\n");
        

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

