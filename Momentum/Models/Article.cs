namespace Momentum.Models;

public class Article
{
    public Guid Id { get; set; }         
    public required string Title { get; set; }     
    public required string Content { get; set; }   
    public DateTime PublishDate { get; set; } 
}