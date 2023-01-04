using System;
using System.Web;

namespace VeraDemoNet.Helpers
{
    public static class Extensions
    {
        private const int MAX_LOG_LENGTH = 400;

        public static string EncodeLog(this string log)
        {
            if (String.IsNullOrEmpty(log))
            {
                return String.Empty;
            }
            if(log.Length > MAX_LOG_LENGTH)
            {
                log = log.Substring(0, MAX_LOG_LENGTH);
            }

            log = log.Replace("\r", "").Replace("\n", "");
            return HttpUtility.HtmlEncode(log);
        }
    }
}