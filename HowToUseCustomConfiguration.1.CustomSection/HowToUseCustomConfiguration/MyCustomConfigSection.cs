using System;
using System.Configuration;

namespace HowToUseCustomConfiguration
{
    public class MyCustomConfigSection : ConfigurationSection
    {
        private static ConfigurationPropertyCollection propertyCollection;
        private static ConfigurationProperty stringProperty;
        private static ConfigurationProperty intProperty;
        private static ConfigurationProperty dateTimeProperty;

        static MyCustomConfigSection()
        {
            propertyCollection = new ConfigurationPropertyCollection();
            stringProperty = new ConfigurationProperty("TextValue", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired);
            intProperty = new ConfigurationProperty("NumericValue", typeof(int), 0, ConfigurationPropertyOptions.None);
            dateTimeProperty = new ConfigurationProperty("DateValue", typeof(DateTime), DateTime.Today, ConfigurationPropertyOptions.None);
            propertyCollection.Add(stringProperty);
            propertyCollection.Add(intProperty);
            propertyCollection.Add(dateTimeProperty);
        }

        [ConfigurationProperty("TextValue", IsRequired=true)]
        public string TextValue { get { return (string)base[stringProperty]; } }

        [ConfigurationProperty("NumericValue")]
        public int NumericValue { get { return (int)base[intProperty]; } }

        [ConfigurationProperty("DateValue")]
        public DateTime DateValue { get { return (DateTime)base[dateTimeProperty]; } }

        protected override ConfigurationPropertyCollection Properties { get { return propertyCollection; } }
    }
}
