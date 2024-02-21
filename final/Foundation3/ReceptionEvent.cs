public class ReceptionEvent : Event
{
    public string RsvpEmail { get; set; }

    public ReceptionEvent(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP at: {RsvpEmail}";
    }
}