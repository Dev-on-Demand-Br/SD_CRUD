using System.ComponentModel.DataAnnotations;

namespace SD.Domain.Models;
public class ProductModel {
    public int Id { get; set; }
    public long Sku { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }


    [Range(1, 1000000)]
    public long Stock { get; set; }


    public int CategoryId { get; set; }
    public CategoryModel? Category { get; set; }
}
