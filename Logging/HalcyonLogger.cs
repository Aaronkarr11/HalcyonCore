using NLog;

namespace HalcyonCore.Logging
{
    public class HalcyonLogger : HalcyonCore.Interfaces.ILogger
    {
        private static HalcyonLogger _instance;
        public static Logger _logger;

        public HalcyonLogger()
        {

        }

        public static HalcyonLogger GetInstance()
        {
            if (_instance == null)
                _instance = new HalcyonLogger();
            return _instance;
        }

        private Logger GetLogger(string theLogger)
        {
            if (HalcyonLogger._logger == null)
            {
                HalcyonLogger._logger = LogManager.GetLogger(theLogger);
            }

            return HalcyonLogger._logger;
        }

        public void Debug(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("HalcyonRules").Debug(message);
            else
                GetLogger("HalcyonRules").Debug(message, arg);
        }

        public void Error(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("HalcyonRules").Error(message);
            else
                GetLogger("HalcyonRules").Error(message, arg);
        }

        public void Info(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("HalcyonRules").Info(message);
            else
                GetLogger("HalcyonRules").Info(message, arg);
        }

        public void Warning(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("HalcyonRules").Warn(message);
            else
                GetLogger("HalcyonRules").Warn(message, arg);
        }
    }
}
