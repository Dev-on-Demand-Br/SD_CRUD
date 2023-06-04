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
    public async Task<ActionResult<List<ProductModel>>> Get() {
        var product = await _productService.GetAllProducts();

        if (product is null) return NotFound("Nenhum produto encontrado.");

        return Ok(product);
    }

    [HttpGet("{id:int}", Name = "GetProduct")]
    public async Task<ActionResult<ProductModel>> Get(int id) {
        var product = await _productService.GetProductById(id);

        if (product is null) return NotFound("Produto não encontrado.");

        return Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] ProductModel product) {
        if (product is null) return BadRequest("Preenchimento incorreto.");

        await _productService.CreateProduct(product);

        return new CreatedAtRouteResult("GetProduct", new { id = product.Id }, product);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, [FromBody] ProductModel product) {
        if (product is null) return BadRequest("Produto não encontrado.");

        await _productService.UpdateProduct(product);

        return Ok(product);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<ProductModel>> Delete(int id) {
        var product = await _productService.GetProductById(id);

        if (product is null) return BadRequest("Produto não encontrado.");

        await _productService.DeleteProduct(id);

        return Ok(product);
    }
}
