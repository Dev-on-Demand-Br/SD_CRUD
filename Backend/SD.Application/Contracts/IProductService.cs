using SD.Domain.Models;

namespace SD.Application.Contracts;
public interface IProductService {

    Task<List<ProductModel>> GetAllProducts();
    Task<ProductModel> GetProductById(Guid id);
    Task<ProductModel> CreateProduct(ProductModel product);
    Task<ProductModel> UpdateProduct(ProductModel product);
    Task<ProductModel> DeleteProduct(Guid id);
}
