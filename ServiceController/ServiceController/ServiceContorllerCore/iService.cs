using System;
namespace ServiceController.ServiceContorllerCore
{
    interface iService
    {
         string ServiceName { get;}
         void ProccessService(string serviceData, IILogger logger);
    }
}
