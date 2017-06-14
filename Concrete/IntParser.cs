using ConfigurationManagerParser.Interfaces;
using System.Configuration;

namespace ConfigurationManagerParser.Concrete
{
    public class IntParser : IConfigurationManagerParser<int>
    {
        public static int Get(string key)
        { 
            string value = ConfigurationManager.AppSettings[key];

            int i = 0;
            bool b = int.TryParse(value, out i);

            return b ? i : int.MaxValue;
        }

        int IConfigurationManagerParser<int>.Get(string key)
        {
            return IntParser.Get(key);
        }
    }
}
