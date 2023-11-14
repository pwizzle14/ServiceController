using System;
namespace ServiceController.ServiceContorllerCore
{
    public class ConsoleLogger: IILogger
    {
        public ConsoleLogger()
        {
        }

        public void LogIt(string logText)
        {
            Console.WriteLine(logText);
        }
    }
}
