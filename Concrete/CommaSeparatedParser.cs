using ConfigurationManagerParser.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace ConfigurationManagerParser.Concrete
{
    public class CommaSeparatedParser : IConfigurationManagerParser<IEnumerable<string>>
    {
        public static IEnumerable<string> Get(string key)
        { 
            string value = ConfigurationManager.AppSettings[key];
            IEnumerable<string> values = value.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var v in values)
                yield return v;
        }

        IEnumerable<string> IConfigurationManagerParser<IEnumerable<string>>.Get(string key)
        {
            return CommaSeparatedParser.Get(key);
        }
    }
}
