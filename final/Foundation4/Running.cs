public class Running : Activity
{
    public double DistanceInMiles { get; set; }

    public Running(DateTime date, double duration, double distance) : base(date, duration)
    {
        DistanceInMiles = distance;
    }

    public override double Distance() => DistanceInMiles;
    public override double Speed() => (DistanceInMiles / DurationInMinutes) * 60;
    public override double Pace() => DurationInMinutes / DistanceInMiles;
}
