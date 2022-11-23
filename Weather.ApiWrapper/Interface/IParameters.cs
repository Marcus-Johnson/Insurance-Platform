
using System;

namespace Weather.ApiWrapper.Interface
{
    public interface IWeatherParameters
    {
        string URL { get; }
        string APIKey { get;}
        string Units { get;}
        string Latitude { get; }
        string Longitude { get; }
        string Fields { get; }
        Uri GetUri();
    }
}
