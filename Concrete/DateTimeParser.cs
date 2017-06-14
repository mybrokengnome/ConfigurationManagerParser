using ConfigurationManagerParser.Interfaces;
using System;
using System.Configuration;

namespace ConfigurationManagerParser.Concrete
{
    public class DateTimeParser : IConfigurationManagerParser<DateTime?>
    {
        public static DateTime? Get(string key)
        { 
            string value = ConfigurationManager.AppSettings[key];

            DateTime ret;
            if (DateTime.TryParse(value, out ret))
                return ret;

            return null;
        }

        DateTime? IConfigurationManagerParser<DateTime?>.Get(string key)
        {
            return DateTimeParser.Get(key);
        }
    }
}
