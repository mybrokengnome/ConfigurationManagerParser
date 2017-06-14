using ConfigurationManagerParser.Interfaces;
using System.Configuration;

namespace ConfigurationManagerParser.Concrete
{
    public class StringParser : IConfigurationManagerParser<string>
    {
        public static string Get(string key)
        { 
            return ConfigurationManager.AppSettings[key];
        }

        string IConfigurationManagerParser<string>.Get(string key)
        {
            return StringParser.Get(key);
        }
    }
}
