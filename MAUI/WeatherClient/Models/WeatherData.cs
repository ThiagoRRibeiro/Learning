namespace WeatherClient.Models
{
    public struct WeatherData(
        int temperature,
        int precipitation,
        int humidity,
        int wind,
        WeatherType condition)
    {
        public int Temperature { get; set; } = temperature;
        public int Precipitation { get; set; } = precipitation;
        public int Humidity { get; set; } = humidity;
        public int Wind { get; set; } = wind;
        public WeatherType Condition { get; set; } = condition;
    }

    public enum WeatherType
    {
        Sunny,
        Cloudy
    }
}
