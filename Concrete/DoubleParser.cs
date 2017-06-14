using ConfigurationManagerParser.Interfaces;
using System.Configuration;

namespace ConfigurationManagerParser.Concrete
{
    public class DoubleParser : IConfigurationManagerParser<double>
    {
        public static double Get(string key)
        { 
            string value = ConfigurationManager.AppSettings[key];

            double d = 0;
            bool b = double.TryParse(value, out d);

            return b ? d : double.MaxValue;
        }

        double IConfigurationManagerParser<double>.Get(string key)
        {
            return DoubleParser.Get(key);
        }
    }
}
