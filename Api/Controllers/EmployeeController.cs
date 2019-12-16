using Api.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _employeeService;
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
    }
}
