using System;
namespace ServiceController.ServiceContorllerCore
{
    interface iService
    {
         string ServiceName { get;}
         void ProccessService(ServiceItem item, IILogger logger);
    }
}
