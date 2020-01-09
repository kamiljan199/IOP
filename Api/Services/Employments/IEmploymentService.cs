using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;

namespace Api.Services
{
    public interface IEmploymentService
    {
        public List<Employment> GetAllEmployments();
        public void CreateEmployement(Employment employment);
    }
}
