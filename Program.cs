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
                "\n Retrive using pop method");

            while (employees.Count > 0) // Loops through until stack is empty 
            {
                Employee employee = employees.Pop(); //returns last object before it removes it from the stack

                Console.WriteLine(
                  $"Name:{employee.Name} - " +
                  $"Gender:{employee.Gender} - " +
                  $"ID:{employee.Id} - " +
                  $"Salary:{employee.Salary}kr\n");
                Console.WriteLine($"Items left in stack: {employees.Count}");

                employees.Push(employee1); // Places object in stack
                employees.Push(employee2);
                employees.Push(employee3);
                employees.Push(employee4);
                employees.Push(employee5);
            }
        }


    }
}

