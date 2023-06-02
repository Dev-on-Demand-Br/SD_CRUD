namespace SD.Domain.Models;
public class CategoryModel {
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<ProductModel>? Products { get; set; }
}
