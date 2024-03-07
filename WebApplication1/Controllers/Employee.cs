using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.Service;
using Web.Service.Model;

namespace Test.Controllers
{
    public class EmployeeController : ApiController
    {
        IEmployeeService ser;
        public EmployeeController()
        {
            ser = StructureMapConfigurator.GetInstance<IEmployeeService>();
        }

        [HttpGet]
        public List<EmployeeServiceModel> getEmployee()
        {
            return ser.getAllEmployee();
        }

    }
}
