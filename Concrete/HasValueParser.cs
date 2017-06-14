using ConfigurationManagerParser.Interfaces;
using System.Configuration;

namespace ConfigurationManagerParser.Concrete
{
    public class HasValueParser : IConfigurationManagerParser<bool>
    {
        public static bool Get(string key)
        { 
            string value = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrEmpty(value))
                return false;

            return true;
        }

        bool IConfigurationManagerParser<bool>.Get(string key)
        {
            return HasValueParser.Get(key);
        }
    }
}
