using SD.Domain.Models;

namespace SD.Application.Interfaces;
public interface ICategoryRepository {
    List<CategoryModel> GetAllCategories();
    CategoryModel CreateCategory(CategoryModel category);
}
