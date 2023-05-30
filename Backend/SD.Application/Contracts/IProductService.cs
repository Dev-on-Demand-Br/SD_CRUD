using SD.Domain.Models;

namespace SD.Application.Contracts;
public interface IProductService {

    // Aqui serão aplicadas as Regras de Negócio "Use cases"

    List<ProductModel> GetAllProducts();
}
