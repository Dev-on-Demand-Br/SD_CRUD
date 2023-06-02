using SD.Domain.Models;

namespace SD.Application.Contracts;
public interface ICategoryService {
    Task<List<CategoryModel>> GetAllCategories();
    Task<List<CategoryModel>> GetCategoriesAndProducts();
    Task<CategoryModel> GetCategoryById(Guid id);
    Task<CategoryModel> CreateCategory(CategoryModel category);
    Task<CategoryModel> UpdateCategory(CategoryModel category);
    Task<CategoryModel> DeleteCategory(Guid id);
}
