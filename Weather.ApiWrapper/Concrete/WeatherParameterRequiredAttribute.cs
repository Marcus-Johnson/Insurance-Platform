using System;

namespace Weather.ApiWrapper.Concrete
{

    public class WeatherParameterRequiredAttribute : Attribute
    { 
        public bool Required { get; private set; }
        public bool HasChildren { get; private set; }
        public WeatherParameterRequiredAttribute(bool required)
        {
            this.Required = required;
        }

        public WeatherParameterRequiredAttribute(bool required, bool hasChildren)
        {
            this.Required = required;
            this.HasChildren = hasChildren;
        }
    }
}
