namespace Momentum.Models;

public class Collection
{
        public Guid Id { get; set; }
        public string? Image { get; set; }  = string.Empty;
        public string? Title { get; set; }  = string.Empty;
        public int FileCount { get; set; }
        public bool IsSelected { get; set; }  
        
}