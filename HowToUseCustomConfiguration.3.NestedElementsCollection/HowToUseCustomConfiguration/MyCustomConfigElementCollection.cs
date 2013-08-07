using System;
using System.Configuration;

namespace HowToUseCustomConfiguration
{
    [ConfigurationCollection(typeof(MyCustomConfigElement), 
        CollectionType=ConfigurationElementCollectionType.AddRemoveClearMap)]
    public class MyCustomConfigElementCollection : ConfigurationElementCollection
    {
        private static ConfigurationPropertyCollection propertyCollection;

        static MyCustomConfigElementCollection()
        {
            propertyCollection = new ConfigurationPropertyCollection();
        }

        protected override ConfigurationPropertyCollection Properties { get { return propertyCollection; } }
        public override ConfigurationElementCollectionType CollectionType { get { return ConfigurationElementCollectionType.AddRemoveClearMap; } }

        public MyCustomConfigElement this[int index]
        {
            get { return (MyCustomConfigElement) base.BaseGet(index); }
            set
            {
                if (base.BaseGet(index) != null)
                    base.BaseRemoveAt(index);
                base.BaseAdd(index, value);
            }
        }

        public new MyCustomConfigElement this[string name]
        {
            get { return (MyCustomConfigElement) base.BaseGet(name); }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new MyCustomConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((MyCustomConfigElement)element).Name;
        }
    }
}
