using Microsoft.EntityFrameworkCore;
using SD.Domain.Models;

namespace SD.Infrastructure.Data;
public class SDContext : DbContext {
    public SDContext(DbContextOptions<SDContext> options) : base(options) {

    }

    public DbSet<ProductModel> Products { get; set; }
    public DbSet<CategoryModel> Categories { get; set; }
}
