using Microsoft.EntityFrameworkCore;
using SD.Application.Interfaces;
using SD.Domain.Models;
using SD.Infrastructure.Data;

namespace SD.Infrastructure.Repositories;
public class CategoryRepository : ICategoryRepository {

    private readonly SDContext _context;
    public CategoryRepository(SDContext context) {
        _context = context;
    }

    public async Task<List<CategoryModel>> GetAllCategories() {
        return await _context.Categories.ToListAsync();
    }
    public async Task<List<CategoryModel>> GetCategoriesAndProducts() {
        return await _context.Categories.Include(c => c.Products).ToListAsync();
    }

    public async Task<CategoryModel> GetCategoryById(int id) {
        return await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<CategoryModel> CreateCategory(CategoryModel category) {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }
    public async Task<CategoryModel> UpdateCategory(CategoryModel category) {
        _context.Entry(category).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<CategoryModel> DeleteCategory(int id) {
        var category = await GetCategoryById(id);
        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
        return category;
    }
}