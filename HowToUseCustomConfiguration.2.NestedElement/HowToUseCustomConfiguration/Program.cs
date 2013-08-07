using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace HowToUseCustomConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            DumpCustomConfigSection();

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }

        private static void DumpCustomConfigSection()
        {
            var cfg = ConfigurationManager.GetSection("MyCustomConfigSection") as MyCustomConfigSection;
            if (cfg == null) return;
            Console.WriteLine("TextValue    : {0}", cfg.TextValue);
            Console.WriteLine("NumericValue : {0}", cfg.NumericValue);
            Console.WriteLine("DateValue    : {0}", cfg.DateValue);
            Console.WriteLine("-- nested --");
            Console.WriteLine("TextValue    : {0}", cfg.NestedElement.TextValue);
            Console.WriteLine("NumericValue : {0}", cfg.NestedElement.NumericValue);

        }
    }
}
