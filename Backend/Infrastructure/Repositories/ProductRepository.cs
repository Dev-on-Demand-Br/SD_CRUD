using SD.Application.Interfaces;
using SD.Domain.Models;

namespace SD.Infrastructure.Repositories;
public class ProductRepository : IProductRepository {

    public static List<ProductModel> products = new List<ProductModel>() {
        new ProductModel { Id = new Guid(), Name = "GX4", Description="Taurus", Price = 3594.00M },
        new ProductModel { Id = new Guid(), Name = "TS9", Description="Taurus", Price = 5780.00M }
    };

    public List<ProductModel> GetAllProducts() {
        return products;
    }
}
