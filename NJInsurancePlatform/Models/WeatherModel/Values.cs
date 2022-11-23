namespace NJInsurancePlatform.Models.WeatherModel
{
    public class Values
    {
        public long PrecipitationType { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public double WindDirection { get; set; }
        public double Temperature { get; set; }
        public double TemperatureApparent { get; set; }
        public double CloudCover { get; set; }
        public double? CloudBase { get; set; }
        public double? CloudCeiling { get; set; }
        public int WeatherCode { get; set; }
        public double? PrecipitationIntensity { get; set; }
    }
}
