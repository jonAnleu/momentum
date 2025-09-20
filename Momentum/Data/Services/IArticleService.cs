using Momentum.Models;
namespace Momentum.Data.Services;

public interface IArticleService
{
    Task<List<Article>> GetAllArticlesAsync();

    Task<Article?> GetArticleByIdAsync(Guid id);

    Task SaveArticleAsync(Article article);

    Task DeleteArticleAsync(Guid id);
}