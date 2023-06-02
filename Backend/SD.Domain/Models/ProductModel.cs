using System.ComponentModel.DataAnnotations;

namespace SD.Domain.Models;
public class ProductModel {
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }

    [Range(1, 5000)]
    public long Stock { get; set; }

    public CategoryModel? Category { get; set; }
    public Guid CategoryId { get; set; }
}
