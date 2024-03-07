using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.Repository;
using Web.Data;
using StructureMap;
using Web.Service.Model;

namespace Web.Service
{
    public class EmployeeService : IEmployeeService
    {
        IRepository<Employee> emp;
        IRepository<Company> cmp;
        public EmployeeService()
        {
            emp = StructureMapConfigurator.GetInstance<IRepository<Employee>>();
            cmp = StructureMapConfigurator.GetInstance<IRepository<Company>>();
        }

        List<EmployeeServiceModel> empList = new List<EmployeeServiceModel>();

        public List<EmployeeServiceModel> getAllEmployee()
        {

            empList.Add(new EmployeeServiceModel() { EmployeeId = 2, FullName = "Mayur" });

            return empList;
        }
    }
}
