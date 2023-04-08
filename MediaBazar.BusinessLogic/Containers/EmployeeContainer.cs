using MediaBazar.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Containers
{
    public class EmployeeContainer : IEmployeeContainer
    {
        private readonly IEmployeeDataAccess _employeeDataAccess;

        public EmployeeContainer(IEmployeeDataAccess employeeDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
        }
    }
}
