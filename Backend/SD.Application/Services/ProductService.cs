using SD.Application.Contracts;
using SD.Application.Interfaces;
using SD.Domain.Models;

namespace SD.Application.Services;
public class ProductService : IProductService {

    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository) {
        _productRepository = productRepository;
    }

    public async Task<List<ProductModel>> GetAllProducts() {
        return await _productRepository.GetAllProducts();
    }

    public async Task<ProductModel> GetProductById(int id) {
        return await _productRepository.GetProductById(id);
    }

    public async Task<ProductModel> CreateProduct(ProductModel product) {
        return await _productRepository.CreateProduct(product);
    }

    public async Task<ProductModel> UpdateProduct(ProductModel product) {
        return await _productRepository.UpdateProduct(product);
    }

    public async Task<ProductModel> DeleteProduct(int id) {
        return await _productRepository.DeleteProduct(id);
    }
}
