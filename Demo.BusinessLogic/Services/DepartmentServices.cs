using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DataAccess.Repo;
namespace Demo.BusinessLogic.Services
{
    internal class DepartmentServices
    {
        readonly private IDepartmentRepo _departmentRepo;

        public DepartmentServices(IDepartmentRepo departmentRepo)// dependency Injection
        {
            _departmentRepo = departmentRepo;
            // DepartmentRepo   test two
        }

    }
}
