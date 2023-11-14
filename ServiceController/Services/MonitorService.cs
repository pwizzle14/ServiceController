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

        public Service Service => Service.MonitorService;

        public void ProccessService(ServiceItem item, IILogger logger)
        {
            try
            {
                Ping ping = new Ping();

                var pingAmount = 100;

                var failedPings = 0;
                var latencySum = 0;

                for(int i = 1; i < pingAmount; i++)
                {
                    PingReply reply = ping.Send(item.ServiceData);

                    if (reply != null)
                    {
                        if (reply.Status != IPStatus.Success)
                            failedPings += 1;
                        else
                            latencySum += (int)reply.RoundtripTime;
                    }
                }

                var averagePing = (latencySum / (pingAmount - failedPings));
                var packetLoss = Convert.ToInt32((Convert.ToDouble(failedPings) / Convert.ToDouble(pingAmount)) * 100);

                string logText = $"Address: {item.ServiceData} - Round Trip Average: {averagePing} ms - PackLoss {packetLoss}";

                logger.LogIt(logText);
            }

            catch (SystemException ex)
            {
                string logText = $"Warning: Address: {item.ServiceData} - offline";
            }
        }
    }
}
