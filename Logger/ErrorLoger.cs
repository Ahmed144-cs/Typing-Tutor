using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingTutor
{
    public static class ErrorLogger
    {
        public static void LogError(string error)
        {
            string sourceName = "TypingTutor";

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }

            EventLog.WriteEntry(sourceName, error, EventLogEntryType.Error);
        }
    }
}
