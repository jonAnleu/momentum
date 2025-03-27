public class Run
{
  public int Id { get; set; }
  public DateTime? Date { get; set; } = null;
  public double? Distance { get; set; } = null;
  public TimeSpan? Duration { get; set; } = null;
  public int? AvgHr { get; set; } = null;
  public string? Notes { get; set; } = null;

  public TimeSpan? Pace
  {
    get
    {
      if (Duration.HasValue && Distance.HasValue && Distance != 0)
      {
        double paceInMinutes = Duration.Value.TotalMinutes / Distance.Value;
        return TimeSpan.FromMinutes(paceInMinutes);
      }
      return null; 
    }
  }

  public Run(DateTime? date, double? distance, TimeSpan? duration, int? avgHr, string? notes)
  {
    Date = date;
    Distance = distance;
    Duration = duration;
    AvgHr = avgHr;
    Notes = notes;
  }

}