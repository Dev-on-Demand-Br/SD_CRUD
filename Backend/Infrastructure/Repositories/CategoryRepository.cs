using SD.Application.Interfaces;
using SD.Domain.Models;
using SD.Infrastructure.Data;

namespace SD.Infrastructure.Repositories;
public class CategoryRepository : ICategoryRepository {

    private readonly SDContext _context;

    public CategoryRepository(SDContext context) {
        _context = context;
    }

    public List<CategoryModel> GetAllCategories() {
        return _context.Categories.ToList();
    }

    public CategoryModel CreateCategory(CategoryModel category) {
        _context.Categories.Add(category);
        _context.SaveChanges();
        return category;
    }
}
