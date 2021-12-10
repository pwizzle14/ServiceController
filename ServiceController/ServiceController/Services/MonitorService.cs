using System;
using System.Net.NetworkInformation;
using ServiceController.ServiceContorllerCore;

namespace ServiceController.Services
{
    public class MonitorService : iService
    {
        public MonitorService()
        {
        }

        public string ServiceName { get => "MonitorService"; }

        public void ProccessService(string serviceData, IILogger logger)
        {
            try
            {
                Ping ping = new Ping();


                PingReply reply = ping.Send(serviceData);

                string logText = $"Address: {serviceData} - RoundTrip: {reply.RoundtripTime} ms - Status: {reply.Status}";

                logger.LogIt(logText);
            }

            catch (SystemException ex)
            {
                string logText = $"Warning: Address: {serviceData} - offline";
            }
        }
    }
}
