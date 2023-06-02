using SD.Application.Contracts;
using SD.Application.Interfaces;
using SD.Domain.Models;

namespace SD.Application.Services;
public class CategoryService : ICategoryService {

    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository) {
        _categoryRepository = categoryRepository;
    }

    public async Task<List<CategoryModel>> GetAllCategories() {
        return await _categoryRepository.GetAllCategories();
    }

    public async Task<List<CategoryModel>> GetCategoriesAndProducts() {
        return await _categoryRepository.GetCategoriesAndProducts();
    }

    public async Task<CategoryModel> GetCategoryById(Guid id) {
        return await _categoryRepository.GetCategoryById(id);
    }
    public async Task<CategoryModel> CreateCategory(CategoryModel category) {
        return await _categoryRepository.CreateCategory(category);
    }

    public async Task<CategoryModel> UpdateCategory(CategoryModel category) {
        return await _categoryRepository.UpdateCategory(category);
    }

    public async Task<CategoryModel> DeleteCategory(Guid id) {
        return await _categoryRepository.DeleteCategory(id);
    }
}
