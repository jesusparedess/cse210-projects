public class Swimming : Activity
{
    public int NumberOfLaps { get; set; }
    private const double LapLengthInMeters = 50;
    private const double MetersToMiles = 0.000621371;

    public Swimming(DateTime date, double duration, int laps) : base(date, duration)
    {
        NumberOfLaps = laps;
    }

    public override double Distance() => NumberOfLaps * LapLengthInMeters * MetersToMiles;
    public override double Speed() => Distance() / (DurationInMinutes / 60);
    public override double Pace() => DurationInMinutes / Distance();
}
