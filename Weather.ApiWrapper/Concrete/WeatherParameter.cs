using System;
using System.Reflection;
using System.Web;
using Weather.ApiWrapper.Config;
using Weather.ApiWrapper.Interface;

namespace Weather.ApiWrapper.Concrete
{
    public class WeatherParameter : IWeatherParameters
    {
        private readonly Type _currentType;
        private readonly PropertyInfo[] _currentTypeProperties;

        public WeatherParameter()
        {
            this._currentType = this.GetType();
            this._currentTypeProperties = this._currentType.GetProperties();
        }

        [WeatherParameterRequired(true)]
        public string APIKey => GetPropertyValue(MethodBase.GetCurrentMethod()?.Name?.Replace("get_", "") ?? "");
        
        [WeatherParameterRequired(true)]
        public string Units => GetPropertyValue(MethodBase.GetCurrentMethod()?.Name?.Replace("get_", "") ?? "");
        
        [WeatherParameterRequired(true)]
        public string Location => $"{this.Latitude},{this.Longitude}";

        [WeatherParameterRequired(true, hasChildren:true)]
        public string Fields => GetPropertyValue(MethodBase.GetCurrentMethod()?.Name?.Replace("get_", "") ?? "");

        public string URL => GetPropertyValue(MethodBase.GetCurrentMethod()?.Name?.Replace("get_", "") ?? "");
        public string Latitude => GetPropertyValue(MethodBase.GetCurrentMethod()?.Name?.Replace("get_", "") ?? "");
        public string Longitude => GetPropertyValue(MethodBase.GetCurrentMethod()?.Name?.Replace("get_", "") ?? "");
        private string GetPropertyValue(string name)
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Property wasn't found");
            }
            else
            {
                var prop = this._currentType?.GetProperty(name);
                var attribute = GetAttribute(prop);

                return attribute == null ? WeatherSettings.Get(name) : WeatherSettings.Get(name, isArray: ((WeatherParameterRequiredAttribute) attribute).HasChildren);
            }
        }
        private Attribute GetAttribute(PropertyInfo propertyInfo)
        {
            return propertyInfo.GetCustomAttribute(typeof(WeatherParameterRequiredAttribute));
        }

        public Uri GetUri()
        {
            var uriBuilder = new UriBuilder(this.URL);

            var query = HttpUtility.ParseQueryString(uriBuilder.Query);

            foreach (var property in this._currentTypeProperties)
            {
                var propertyInfo = this._currentType?.GetProperty(property.Name);
                
                var attribute = GetAttribute(propertyInfo);

                if (attribute == null) continue;

                if (!((WeatherParameterRequiredAttribute) attribute).Required) continue;
                
                var value = propertyInfo?.GetValue(this)?.ToString();

                query[property.Name.ToLower()] = value;
            }

            uriBuilder.Query = query.ToString() ?? string.Empty;

            return uriBuilder.Uri;
        }

       
    }
}
