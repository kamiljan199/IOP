using Api.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Api.DTOs;
using Api.Enums;
using Model.Models;
using System.Security.Cryptography;

namespace Api.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _employeeService;
        private static int? _loggedEmployeeId;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        //TODO: Zwalnia pracownika o podanym numerze ID
        public void FireEmployeeById(int employeeId)
        {
            try
            {
                //TODO: do what's necessary to end this man whole career
                _employeeService.RemoveEmployeeById(employeeId);
            }
            catch(Exception ex)
            {
                
            }
        }

        public EmployeesDTO GetAllEmployees()
        {
            try
            {
                var employeesCollection = _employeeService.GetAllEmployees();

                var result = new EmployeesDTO
                {
                    Employees = employeesCollection,
                    Status = CollectionGetStatus.Success
                };

                return result;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

                    var result = new EmployeesDTO
                {
                    Status = CollectionGetStatus.Failure
                };

                return result;
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            _employeeService.RemoveEmployee(employee);
        }

        public void AddEmployee(Employee employee)
        {
            employee.Password = HashPassword(employee.Password);
            _employeeService.AddEmployee(employee);
        }

        public void UpdateEmployee(Employee employee, bool IsPasswordModified)
        {
            if (IsPasswordModified)
            {
                employee.Password = HashPassword(employee.Password);
            }
            _employeeService.UpdateEmployee(employee);
        }

        public bool Login(string login, string password)
        {
            var employee = _employeeService.GetEmployeeByLogin(login);
            if (employee != null)
            {
                var hashedPassword = HashPassword(password);
                if (employee.Password.Equals(hashedPassword))
                {
                    _loggedEmployeeId = employee.Id;
                    return true;
                }
            }

            return false;
        }

        public Employee GetLoggedEmployee()
        {
            if (_loggedEmployeeId != null)
            {
                return _employeeService.GetEmployeeById(_loggedEmployeeId.GetValueOrDefault());
            }

            return null;
        }

        public void Logout()
        {
            _loggedEmployeeId = null;
        }

        private string HashPassword(string password)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return System.Convert.ToBase64String(sha1.ComputeHash(passwordBytes));
        }
    }
}
