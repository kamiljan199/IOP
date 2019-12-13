using Api.Managers;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Services
{
    public interface IPackageService
    {
        public Package GetById(int id);
    }
}
