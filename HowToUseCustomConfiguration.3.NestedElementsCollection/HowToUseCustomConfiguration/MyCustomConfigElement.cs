using System;
using System.Configuration;

namespace HowToUseCustomConfiguration
{
    public class MyCustomConfigElement : ConfigurationElement
    {
        private static ConfigurationPropertyCollection propertyCollection;
        private static ConfigurationProperty nameProperty;
        private static ConfigurationProperty stringProperty;
        private static ConfigurationProperty intProperty;

        static MyCustomConfigElement()
        {
            propertyCollection = new ConfigurationPropertyCollection();
            nameProperty = new ConfigurationProperty("Name", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired);
            stringProperty = new ConfigurationProperty("TextValue", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired);
            intProperty = new ConfigurationProperty("NumericValue", typeof(int), 0, ConfigurationPropertyOptions.None);
            propertyCollection.Add(nameProperty);
            propertyCollection.Add(stringProperty);
            propertyCollection.Add(intProperty);
        }

        [ConfigurationProperty("Name", IsRequired = true)]
        public string Name { get { return (string)base[nameProperty]; } }

        [ConfigurationProperty("TextValue", IsRequired = true)]
        public string TextValue { get { return (string)base[stringProperty]; } }

        [ConfigurationProperty("NumericValue")]
        public int NumericValue { get { return (int)base[intProperty]; } }

        protected override ConfigurationPropertyCollection Properties { get { return propertyCollection; } }
    }
}
