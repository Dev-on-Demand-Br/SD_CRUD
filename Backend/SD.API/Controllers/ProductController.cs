using Microsoft.AspNetCore.Mvc;
using SD.Application.Contracts;
using SD.Domain.Models;

namespace SD.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase {

    private readonly IProductService _productService;

    public ProductController(IProductService productService) {
        _productService = productService;
    }

    [HttpGet]
    public ActionResult<List<ProductModel>> GetProducts() {
        var products = _productService.GetAllProducts();
        return Ok(products);
    }

}
