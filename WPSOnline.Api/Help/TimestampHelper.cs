using System;

namespace WPSOnline.Api.Help
{
    public class TimestampHelper
    {
        public static int GetCurrentTimestamp()
        {
            DateTime dtnow=new DateTime(1970,1,1,0,0,0,DateTimeKind.Utc);
            return (int)(DateTime.Now.AddHours(-8) - dtnow).TotalSeconds;
        }

        public static int ConvertToTimeStamp(DateTime time)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return (int)(time.AddHours(-8) - dt).TotalSeconds;
        }

        public static DateTime ConvertToDateTime(long timeStamp)
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return start.AddSeconds(timeStamp).AddHours(8);
        }
    }
}
