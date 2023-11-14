using System;
using ServiceController.ServiceContorllerCore;

namespace ServiceController.Services
{
    public class NotificationService: iService
    {
        public NotificationService() { }

        public Service Service => Service.NotificationService;

        public void ProccessService(ServiceItem item, IILogger logger)
        {
            //Todo: sendEmail service.
        }
    }
}
