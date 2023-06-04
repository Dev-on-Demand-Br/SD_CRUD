namespace SD.Domain.Models;
public class CategoryModel {
    public int Id { get; set; }
    public long Code { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<ProductModel>? Products { get; set; }
}
