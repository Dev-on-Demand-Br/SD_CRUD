using SD.Application.Interfaces;
using SD.Domain.Models;

namespace SD.Infrastructure.Repositories;
public class CategoryRepository : ICategoryRepository {

    public static List<CategoryModel> categories = new List<CategoryModel>() {
        new CategoryModel { Id = new Guid(), Name = "Pistola" },
        new CategoryModel { Id = new Guid(), Name  = "Revólver" }
    };

    public List<CategoryModel> GetAllCategories() {
        return categories;
    }
}
