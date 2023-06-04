using Microsoft.EntityFrameworkCore;
using SD.Application.Interfaces;
using SD.Domain.Models;
using SD.Infrastructure.Data;

namespace SD.Infrastructure.Repositories;
public class ProductRepository : IProductRepository {

    private readonly SDContext _context;

    public ProductRepository(SDContext context) {
        _context = context;
    }

    public Task<List<ProductModel>> GetAllProducts() {
        return _context.Products.ToListAsync();
    }

    public async Task<ProductModel> GetProductById(int id) {
        return await _context.Products.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<ProductModel> CreateProduct(ProductModel product) {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<ProductModel> UpdateProduct(ProductModel product) {
        _context.Entry(product).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<ProductModel> DeleteProduct(int id) {
        var product = await GetProductById(id);
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
        return product;
    }
}
