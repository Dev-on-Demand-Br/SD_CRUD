using SD.Domain.Models;

namespace SD.Application.Interfaces;
public interface IProductRepository {

    // Essa interface será responsável por adquirir dados

    List<ProductModel> GetAllProducts();
    ProductModel CreateProduct(ProductModel product);
}
