using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    public static class clsLogger
    {
        private const string SourceApp = "DVLD";

        public static void LogException(string message, EventLogEntryType entryType)
        {

            try
            {
                if (!EventLog.SourceExists(SourceApp))
                    EventLog.CreateEventSource(SourceApp, "Application");

                EventLog.WriteEntry(SourceApp, message, entryType);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(SourceApp, "Exception in LogException Method: " + ex.Message, EventLogEntryType.Error);
            }
            
        }

        public static void LogException(Exception ex)
        {
            string message = $"{DateTime.Now}\n{ex.Message}\n{ex.StackTrace}";
            LogException(message, EventLogEntryType.Error);
        }

    }
}
