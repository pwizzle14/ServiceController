using System;
namespace ServiceController.ServiceContorllerCore
{
    public class ServiceItem
    {
        public ServiceItem()
        {
        }

        public int ServiceId { get; set; }
        public string ServiceData { get; set; } //JSON of data to be used by the serive. 
        public int ServiceStatus { get; set; }
    }


}
