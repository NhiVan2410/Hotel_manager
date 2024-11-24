using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class EmployeeService
    {
        public void AddEmployee(string name, string position, string password, string contactInfo)
        {
            using (var context = new HotelDbContext())
            {
                var employee = new Employee
                {
                    Name = name,
                    Position = position,
                    Password = password,
                    ContactInfo = contactInfo,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsDeleted = 1,
                };
            

                context.Employees.InsertOnSubmit(employee);
                context.SubmitChanges();
            }
        }
        // Thêm Manager
        public void AddManager(Manager1 manager1)
        {
            AddEmployee(
                manager1.Name,
                "Manager", // Vị trí là Manager
                manager1.Password,
                manager1.ContactInfo
            );
            var manager = new Manager1
            {
                Name = "Anh Thy",
                Password = "1234",
                ContactInfo = "AnhThy@gmail.com"
            };

            var employeeService = new EmployeeService();
            employeeService.AddManager(manager);

            Console.WriteLine("Manager added successfully.");
        }
        public void AddReceptionist(Receptionist1 receptionist1)
        {
            AddEmployee(
                receptionist1.Name,
                "Receptionist", // Vị trí là Receptionist
                receptionist1.Password,
                receptionist1.ContactInfo
            );
            var employeeService = new EmployeeService();
            var receptionist = new Receptionist1
            {
                Name = "Jane Smith",
                Password = "AnotherSecurePassword",
                ContactInfo = "jane.smith@example.com"
            };

            employeeService.AddReceptionist(receptionist);

            Console.WriteLine("Receptionist added successfully.");
        }
        // danh sách nhân viên
        public IQueryable<Employee> GetEmployeesByPosition(string position)
        {
       
            using (var context = new HotelDbContext())
            {
                return context.Employees.Where(e => e.Position == position && e.IsDeleted == 0);
            }
           
        }
        public void DisplayEmployeesByPosition()
        {
            var employeeService = new EmployeeService();

            // Lấy danh sách Manager
            var managers = employeeService.GetEmployeesByPosition("Manager");
            foreach (var manager in managers)
            {
                Console.WriteLine($"Manager: {manager.Name}, Contact: {manager.ContactInfo}");
            }

            // Lấy danh sách Receptionist
            var receptionists = employeeService.GetEmployeesByPosition("Receptionist");
            foreach (var receptionist in receptionists)
            {
                Console.WriteLine($"Receptionist: {receptionist.Name}, Contact: {receptionist.ContactInfo}");
            }
        }
        // xóa mềm nhân viên
        public void DeleteEmployee(int employeeId)
        {
            using (var context = new HotelDbContext())
            {
                var employee = context.Employees.FirstOrDefault(e => e.EmployeeID == employeeId);
                if (employee != null)
                {
                    employee.IsDeleted = 1; // đúng
                    employee.UpdatedAt = DateTime.Now;
                    context.SubmitChanges();
                }
            }
        }


    }
}
