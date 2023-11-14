using System;
using ServiceController.ServiceContorllerCore;
using ServiceController.Services;

namespace ServiceController
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Service Controller. This is just a proof of concept. Hit any key to continue: ");
            Console.ReadKey();

            //test data
            GetService(1, "www.google.com");

        }

        public static void GetService(int serviceId, string serviceData)
        {
            if(serviceId == 1)
            {
                RunService(new MonitorService(), serviceData);
            }
        }

        private static void RunService(iService service, string serviceData)
        {
            var item = new ServiceItem
            {
                ServiceData = serviceData,
                ServiceId = (int)service.Service,
                ServiceStatus = 0
            };

            service.ProccessService(item, new ConsoleLogger());
            
        }
    }
}
