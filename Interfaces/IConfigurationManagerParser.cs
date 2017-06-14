using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationManagerParser.Interfaces
{
    public interface IConfigurationManagerParser<T>
    {
        T Get(string key);
    }
}
