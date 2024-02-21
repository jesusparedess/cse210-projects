public class OutdoorEvent : Event
{
    public string WeatherForecast { get; set; }

    public OutdoorEvent(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather Forecast: {WeatherForecast}";
    }
}