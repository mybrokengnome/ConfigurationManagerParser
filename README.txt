# Configuration Manager Parser

## Purpose
To make getting data from the web.config's appSettings section easier

## Usage
There's currently 7 parsers
    
    * BooleanParser
    * CommaSeparatedParser
    * DateTimeParser
    * DoubleParser
    * HasValueParser
    * IntParser
    * StringParser

The 5 parsers for the primative types can be called like

     <Parser>.Get("key")

     Setting: <add key="IsEnabled" value="true" />
     Example: BooleanParser.Get("IsEnabled");
     Returns: true

     Setting: <add key="PortNumber" value="8080" />
     Example: IntParser.Get("PortNumber");
     Returns: 8080

HasValueParser functions the same was, but instead of returning the value of the key, it returns whether or not the app setting has a value or if it exists. Useful for optional app settings

    Example: HasValueParser.Get("Foo");
    Returns: true if Foo is in web.config, false if not.        

CommaSeparatedParser returns an IEnumerable<string>, after splitting the value with a comma delimiter

    Setting: <add key="MyList" value="abc,123,xyz" />
    Example: foreach (var v in CommaSeparatedParser.Get("MyList"))
                    Console.Write(v + " ");
    Returns: abc 123 xyz

    Note: It is up to the user to parse the results of the CommaSeparatedParser, the parser just returns them as strings
     
