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
                var service = new MonitorService();
                RunService(service, serviceData);
            }
        }

        private static void RunService(iService service, string serviceData)
        {
            service.ProccessService(serviceData, new ConsoleLogger());
            
        }
    }
}
