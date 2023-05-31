using SD.Domain.Models;

namespace SD.Application.Contracts;
public interface ICategoryService {
    List<CategoryModel> GetAllCategories();
    CategoryModel CreateCategory(CategoryModel category);
}
