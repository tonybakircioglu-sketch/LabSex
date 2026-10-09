namespace LabSex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(14564,30000, "Tony", "Male");
            Employee employee2 = new Employee(14565,39000, "Kevin", "Male");
            Employee employee3 = new Employee(14566,29000, "Anton", "Male");
            Employee employee4 = new Employee(14567,32500, "Johanna", "Female");
            Employee employee5 = new Employee(14568,38000, "Anna", "Female");


            Stack<Employee> employees = new Stack<Employee>();
            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            foreach(Employee employee in employees)
           
                Console.WriteLine($"Items left in stack: {employees.Count}\n"+
                    $"Name:{employee.Name} - " +
                    $"Gender:{employee.Gender} - " +
                    $"ID:{employee.Id} - " +
                    $"Salary:{employee.Salary}kr\n");
            }


        }
    }

