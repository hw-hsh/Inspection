using System;

using log4net;
using log4net.Appender;
using log4net.Layout;
using log4net.Repository.Hierarchy;

namespace HFR_Inspection.etc
{
    public class L4Logger
    {
        //private static L4Logger LoggerInstance;

        public ILog log;
        public RollingFileAppender rollingAppender;
        public PatternLayout layout;
        public log4net.Filter.LoggerMatchFilter lmf;

        //public static L4Logger GetInstance()
        //{
        //    if (LoggerInstance == null)
        //    {
        //        LoggerInstance = new L4Logger();
        //    }

        //    return LoggerInstance;
        //}


        public L4Logger(string path, string LoggerName)
        {
            string date = string.Format("{0:00}{1:00}{2:00}.log", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            //string FilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Log\\App.log"; //실행폴더 아래에 Log폴더
            //string FilePath = AppDomain.CurrentDomain.BaseDirectory + "\\" + path + "\\" + date; //실행폴더 아래에 Log폴더
            string FilePath = path + "\\" + date; //실행폴더 아래에 Log폴더

            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
            hierarchy.Configured = true;

            log4net.Filter.LoggerMatchFilter lmf = new log4net.Filter.LoggerMatchFilter();
            lmf.LoggerToMatch = LoggerName;
            lmf.AcceptOnMatch = true;

            RollingFileAppender rollingAppender = new RollingFileAppender();
            rollingAppender.Name = LoggerName;
            rollingAppender.File = FilePath; // 로그 파일 이름
            rollingAppender.AppendToFile = true;

            rollingAppender.AddFilter(lmf);

            rollingAppender.StaticLogFileName = true;
            rollingAppender.CountDirection = 1;
            rollingAppender.RollingStyle = RollingFileAppender.RollingMode.Date;
            rollingAppender.LockingModel = new FileAppender.MinimalLock();
            rollingAppender.DatePattern = "_yyyyMMdd\".log\""; // 날짜가 변경되면 이전 로그에 붙은 이름

            //PatternLayout layout = new PatternLayout("%date [%-5level] %message%newline");//로그 출력 포맷
            PatternLayout layout = new PatternLayout("%date{HH:mm:ss,fff} - %message%newline");//로그 출력 포맷

            rollingAppender.Layout = layout;

            //hierarchy.Root.AddAppender(rollingAppender);
            rollingAppender.ActivateOptions();
            //hierarchy.Root.Level = log4net.Core.Level.All;

            log = LogManager.GetLogger(LoggerName);

            Logger l = (Logger)log.Logger;
            l.AddAppender(rollingAppender);

        }

        public void Write(string LogMsg)
        {
            log.Debug(LogMsg);
        }

        public void Write_Info(string LogMsg)
        {
            log.Info(LogMsg);
        }

        public void Write_Warn(string LogMsg)
        {
            log.Warn(LogMsg);
        }

        public void Close()
        {
            LogManager.Shutdown();
        }
    }
}
