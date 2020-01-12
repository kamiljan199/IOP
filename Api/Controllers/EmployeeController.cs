using Api.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Api.DTOs;
using Api.Enums;
using Model.Models;

namespace Api.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public void HireEmployee(Employee employee, Employment employment)
        {
            //TODO: jeśli activeEmployment jest to except
            _employeeService.HireEmployee(employee, employment);
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

        public void CreateEmployee(string name, string surname, string PESEL, DateTime birthday)
        {
            var employee = new Employee
            {
                Name = name,
                Surname = surname,
                Pesel = PESEL,
                Birthday = birthday
            };

            _employeeService.AddEmployee(employee);
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
            _employeeService.AddEmployee(employee);
        }
    }
}
