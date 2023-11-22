namespace WebApplication1__ctceTrainingPlural.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
