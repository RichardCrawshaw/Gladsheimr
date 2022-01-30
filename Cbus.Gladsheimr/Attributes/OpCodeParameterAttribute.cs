using System;

namespace Cbus.Gladsheimr.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class OpCodeParameterAttribute : Attribute
    {
        public string? PropertyName { get; set; }
        public string? TypeName { get; set; }
        public string? Name { get; set; }
        public string? DataType { get; set; }

        public OpCodeParameterAttribute(string propertyName, string typeName, string name, string dataType)
        {
            this.PropertyName = propertyName;
            this.TypeName = typeName;
            this.Name = name;
            this.DataType = dataType;
        }
    }
}
