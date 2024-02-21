public class Cycling : Activity
{
    public double SpeedInMph { get; set; }

    public Cycling(DateTime date, double duration, double speed) : base(date, duration)
    {
        SpeedInMph = speed;
    }

    public override double Distance() => (SpeedInMph * DurationInMinutes) / 60;
    public override double Speed() => SpeedInMph;
    public override double Pace() => 60 / SpeedInMph;

}