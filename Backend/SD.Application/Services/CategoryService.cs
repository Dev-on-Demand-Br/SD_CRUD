using SD.Application.Contracts;
using SD.Application.Interfaces;
using SD.Domain.Models;

namespace SD.Application.Services;
public class CategoryService : ICategoryService {

    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository) {
        _categoryRepository = categoryRepository;
    }

    public List<CategoryModel> GetAllCategories() {
        var categories = _categoryRepository.GetAllCategories();
        return categories;
    }

    public CategoryModel CreateCategory(CategoryModel category) {
        _categoryRepository.CreateCategory(category);
        return category;
    }
}
