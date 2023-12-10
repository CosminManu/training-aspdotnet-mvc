namespace WebApplication1__ctceTrainingPlural.Models;

public class CategoryRepository
{
    private readonly AppDbContext _appDbContext;

    public CategoryRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public IEnumerable<Category> AllCategories => _appDbContext.Categories;
}