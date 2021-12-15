using System;
using ServiceController.ServiceContorllerCore;

namespace ServiceController.Services
{
    public class NoService: iService
    {
        public NoService()
        {
        }

        public string ServiceName => "NoService";

        public void ProccessService(ServiceItem item, IILogger logger)
        {
            logger.LogIt($"ServiceId: {item.ServiceId} is not found");
        }
    }
}
