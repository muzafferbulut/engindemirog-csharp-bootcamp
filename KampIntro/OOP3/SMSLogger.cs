using System;

namespace OOP3
{
    class SMSLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS loglandı.");
        }
    }
}
