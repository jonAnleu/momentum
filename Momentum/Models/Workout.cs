public class Workout {
  public int Id { get; set; }
  public DateOnly Date { get; set; }
  public double Distance { get; set; }
  public TimeOnly Duration { get; set; }
  public int AvgHr { get; set; }
  public TimeOnly Pace { get; set; }
  public string? Notes { get; set; }

  public Workout (DateOnly date, double distance, TimeOnly duration, int avgHr, TimeOnly pace, string notes)
  {
    Date = date;
    Distance = distance;
    Duration = duration;
    AvgHr = avgHr;
    Pace = pace;
    Notes = notes;
  }
  
}