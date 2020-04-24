using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _db;
        public EmployeeService(ApplicationDbContext db)
        {
            _db = db;

        }
        //cruds Employees
        //get All Employees
        public List<EmployeeInfo> getAllEmployee()
        {
            var empList = _db.Employees.ToList();
            return empList;
        }
        //create a Employee
        public string CreateEmployee(EmployeeInfo objEmployee)
        {
            _db.Employees.Add(objEmployee);
            _db.SaveChanges();
            return "Employee Created Successfull";
        }

        //get employee by Id
        public EmployeeInfo getEmployeeById(int id)
        {
            EmployeeInfo employee = _db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            return employee;
        }
        //update Employee
        public string updateEmployee(EmployeeInfo objEmployee)
        {
            _db.Employees.Update(objEmployee);
            _db.SaveChanges();
            return "Employee Updated Succsessfull";
        }
        //delete Employee
        public string deleteEmployee(EmployeeInfo employee)
        {
            _db.Remove(employee);
            _db.SaveChanges();
            return "Employee Deleted Successfull";
        }
    }
}
