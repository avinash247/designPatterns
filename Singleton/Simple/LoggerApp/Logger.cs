using System;

namespace LoggerApp
{
    public class Logger
    {
        private static Logger _logger = new Logger();

        //make the constructor private so that this class cannot be
        //instantiated
        private Logger() { }

        //Get the only object available
        public static Logger GetInstance()
        {
            return _logger;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
