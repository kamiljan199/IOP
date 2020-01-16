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

        public EmployeesDTO GetEmployeesByPositionId(int positionId)
        {
            try
            {
                var employeesCollection = _employeeService.GetEmployeesByPositionId(positionId);

                var result = new EmployeesDTO
                {
                    Employees = employeesCollection,
                    Status = CollectionGetStatus.Success
                };

                return result;
            }
            catch (Exception e)
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

        public void AddEmployee(Employee employee, bool detach = false)
        {
            employee.Password = HashPassword(employee.Password);
            _employeeService.AddEmployee(employee, detach);
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

        public Employee GetEmployeeById(int id)
        {
            return _employeeService.GetEmployeeById(id);
        }

        private string HashPassword(string password)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return System.Convert.ToBase64String(sha1.ComputeHash(passwordBytes));
        }
    }
}
