using System;
using ServiceController;

namespace ServiceController.ServiceContorllerCore
{
    interface iService
    {
        Service Service { get; }
        
         void ProccessService(ServiceItem item, IILogger logger);
    }
}
