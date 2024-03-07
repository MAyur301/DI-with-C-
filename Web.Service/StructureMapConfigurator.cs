using System;
using System.Collections.Generic;
using StructureMap;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.Repository;
using Web.Data;

namespace Web.Service
{
    public static class StructureMapConfigurator
    {
        public static Container container { get; set; }
        public static bool _isInitialized;

        public static void Configure()
        {
            container = new Container(x =>
            {
                x.For<IRepository<Employee>>().Use(() => new Repository<Employee>());
                x.For<IRepository<Company>>().Use(() => new Repository<Company>());
                //x.For<IEmployeeService>().Use(() => new EmployeeSer());
                x.For<IEmployeeService>().Use<EmployeeService>();
            });
        }

        public static T GetInstance<T>()
        {
            if (!_isInitialized)
                Configure();
            return container.GetInstance<T>();
        }
    }
}
