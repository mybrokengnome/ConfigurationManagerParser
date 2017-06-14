using ConfigurationManagerParser.Interfaces;
using System.Configuration;

namespace ConfigurationManagerParser.Concrete
{
    public class BooleanParser : IConfigurationManagerParser<bool>
    {
        public static bool Get(string key)
        { 
            string value = ConfigurationManager.AppSettings[key];

            bool b = false;
            bool b2 = bool.TryParse(value, out b);

            return b2 ? b : false;
        }

        bool IConfigurationManagerParser<bool>.Get(string key)
        {
            return BooleanParser.Get(key);
        }
    }
}
