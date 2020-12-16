using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SQLController
{
    class Util
    {
        public static string GetServ(string serv)
        {
            switch (serv)
            {
                case "SQL SERVER":
                    return "MSSQLSERVER";
                case "MYSQL":
                    return "MySQL80";
                case "JAVA":
                    return "java";
                default:
                    return "";
            }
        }

        public static string DoesServiceExist(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices("DESKTOP-4F05GBH");
            var service = services.FirstOrDefault(s => s.ServiceName == serviceName);

            return service.Status.ToString();
        }

        public static List<string> ListServices(string search)
        {
            List<string> servicesList = new List<string>();

            ServiceController[] services = ServiceController.GetServices("DESKTOP-4F05GBH");

            if(search.Length == 0)
            {
                foreach (var serv in services)
                {
                    servicesList.Add(serv.ServiceName + " - " + serv.DisplayName);
                }
            }
            else
            {
                foreach (var serv in services)
                {
                    if (serv.ServiceName.ToLower().Contains(search.ToLower()) || serv.DisplayName.ToLower().Contains(search.ToLower()))
                    {
                        servicesList.Add(serv.ServiceName + " - " + serv.DisplayName);
                    }
                }
            }

            servicesList.Sort();

            return servicesList;
        }
    }
}
