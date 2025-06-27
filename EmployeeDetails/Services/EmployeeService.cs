using EmployeeDetails.Models;
namespace EmployeeDetails.Services
{
    public interface IEmployeeService
    {
        Employee AddEmployee(Employee employee);
        Employee UpdatedEmployee(int id, Employee employee);
    }

    public class EmployeeService : IEmployeeService
    {
        private   List<Employee> employees;
        public Employee AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return (employee);
        }

        public Employee UpdatedEmployee(int id,Employee employee)
        {
            if(id == null) { return null; }
            var updatedemplyee = employees.FirstOrDefault(e => e.Id == id);
            employee.Name = updatedemplyee.Name;
            employee.Salary = updatedemplyee.Salary;
            return (employee);

        }
    }
}
