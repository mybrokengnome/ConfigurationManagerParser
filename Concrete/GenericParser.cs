using ConfigurationManagerParser.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ConfigurationManagerParser.Concrete
{
    public static class GenericParser<T>
    {
        public static T Get(string key)
        {
            string value = ConfigurationManager.AppSettings[key];
            var type = typeof(T);
            var converter = TypeDescriptor.GetConverter(type);

            if (converter != null && converter.IsValid(value))
                return (T)converter.ConvertFromString(value);
            else
                return (T)Activator.CreateInstance(type);
        }
    }
}
