using SD.Application.Contracts;
using SD.Application.Interfaces;
using SD.Domain.Models;

namespace SD.Application.Services;
public class ProductService : IProductService {

    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository) {
        _productRepository = productRepository;
    }

    public List<ProductModel> GetAllProducts() {
        var products = _productRepository.GetAllProducts();
        return products;
    }

    public ProductModel CreateProduct(ProductModel product) {
        _productRepository.CreateProduct(product);
        return product;
    }
}
