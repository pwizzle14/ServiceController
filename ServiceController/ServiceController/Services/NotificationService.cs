using System;
using ServiceController.ServiceContorllerCore;

namespace ServiceController.Services
{
    public class NotificationService: iService
    {
        public NotificationService()
        {
        }

        public string ServiceName => "Notification Service";

        public void ProccessService(ServiceItem item, IILogger logger)
        {
            //sendEmail service.
        }
    }
}
