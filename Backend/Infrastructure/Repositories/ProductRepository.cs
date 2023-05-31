using SD.Application.Interfaces;
using SD.Domain.Models;
using SD.Infrastructure.Data;

namespace SD.Infrastructure.Repositories;
public class ProductRepository : IProductRepository {

    private readonly SDContext _context;

    public ProductRepository(SDContext context) {
        _context = context;
    }

    public List<ProductModel> GetAllProducts() {
        return _context.Products.ToList();
    }

    public ProductModel CreateProduct(ProductModel product) {
        _context.Products.Add(product);
        _context.SaveChanges();
        return product;
    }
}
