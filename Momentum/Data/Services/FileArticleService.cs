
using System.Text.Json;
using Momentum.Models;
using Momentum.Data.Services;

namespace Momentum.Data.Services
{
    public class FileArticleService : IArticleService // Implement the interface
    {
        // Path to the directory where article files will be stored
        private readonly string _dataDirectory;

        // Constructor: the path is provided via dependency injection
        public FileArticleService(IWebHostEnvironment webHostEnvironment)
        {
            // Combine the web root path with a "Data/Articles" folder
            _dataDirectory = Path.Combine(webHostEnvironment.WebRootPath, "Data", "Articles");

            // Ensure the directory exists! Crucial step.
            if (!Directory.Exists(_dataDirectory))
            {
                Directory.CreateDirectory(_dataDirectory);
            }
        }

        // Helper method to build the full file path for a given article ID
        private string GetFilePath(Guid id) => Path.Combine(_dataDirectory, $"{id}.json");

        // GET ALL ARTICLES
        public async Task<List<Article>> GetAllArticlesAsync()
        {
            var articles = new List<Article>();

            // Check if the directory exists (it might not on first run)
            if (!Directory.Exists(_dataDirectory))
                return articles; // Return an empty list

            // Get all .json files in the directory
            var filePaths = Directory.GetFiles(_dataDirectory, "*.json");

            // Loop through each file path
            foreach (var filePath in filePaths)
            {
                // Read the text from the file asynchronously
                var json = await File.ReadAllTextAsync(filePath);
                
                // Deserialize the JSON text into an Article object
                var article = JsonSerializer.Deserialize<Article>(json);
                
                // If deserialization was successful, add it to the list
                if (article != null)
                    articles.Add(article);
            }

            // Optional: Sort the articles by publish date, newest first
            return articles.OrderByDescending(a => a.PublishDate).ToList();
        }

        // GET ARTICLE BY ID
        public async Task<Article?> GetArticleByIdAsync(Guid id)
        {
            var filePath = GetFilePath(id);

            // Check if the file exists before trying to read it
            if (!File.Exists(filePath))
                return null; // Return null if not found

            // Read and deserialize the file
            var json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<Article>(json);
        }

        // SAVE ARTICLE (Create or Update)
        public async Task SaveArticleAsync(Article article)
        {
            // If it's a new article (ID is empty), generate a new ID
            if (article.Id == Guid.Empty)
                article.Id = Guid.NewGuid();

            // Ensure the PublishDate is set. If not, use the current time.
            if (article.PublishDate == default)
                article.PublishDate = DateTime.UtcNow; // Using UTC is good practice

            // Configure JSON serialization options to make the output pretty
            var options = new JsonSerializerOptions { WriteIndented = true };
            
            // Serialize the Article object to a JSON string
            var json = JsonSerializer.Serialize(article, options);
            
            // Get the file path for this article's ID
            var filePath = GetFilePath(article.Id);
            
            // Write the JSON string to the file asynchronously
            await File.WriteAllTextAsync(filePath, json);
        }

        // DELETE ARTICLE
        public async Task DeleteArticleAsync(Guid id)
        {
            var filePath = GetFilePath(id);

            // Check if the file exists before trying to delete it
            if (File.Exists(filePath))
            {
                // Delete the file
                File.Delete(filePath);
            }
            // The 'await Task.CompletedTask;' is just to satisfy the async method requirement
            // since File.Delete is a synchronous operation.
            await Task.CompletedTask;
        }
    }
}