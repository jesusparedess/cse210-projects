public abstract class Activity
{
    public DateTime Date { get; set; }
    public double DurationInMinutes { get; set; }

    protected Activity(DateTime date, double duration)
    {
        Date = date;
        DurationInMinutes = duration;
    }

    public abstract double Distance(); 
    public abstract double Speed(); 
    public abstract double Pace(); 

    
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} - {GetType().Name} ({DurationInMinutes} min): Distance {Distance():0.0} miles, Speed {Speed():0.0} mph, Pace: {Pace():0.0} min per mile";
    }
}