using Microsoft.AspNetCore.Mvc;
using SD.Application.Contracts;
using SD.Domain.Models;

namespace SD.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase {

    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService) {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<ActionResult<List<CategoryModel>>> Get() {
        var categories = await _categoryService.GetAllCategories();

        if (categories is null) return NotFound("Nenhuma categoria econtrada.");

        return Ok(categories);
    }

    [HttpGet("products")]
    public async Task<ActionResult<List<CategoryModel>>> GetAllCategoriesAndProducts() {
        var content = await _categoryService.GetCategoriesAndProducts();
        if (content is null) return NotFound("Nenhuma categoria encontrada.");
        return Ok(content);
    }

    [HttpGet("{id:Guid}", Name = "GetCategory")]
    public async Task<ActionResult<CategoryModel>> Get(Guid id) {
        var category = await _categoryService.GetCategoryById(id);

        if (category is null) return NotFound("Categoria não encontrada.");

        return Ok(category);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CategoryModel category) {
        if (category is null) return BadRequest("Preenchimento incorreto.");

        await _categoryService.CreateCategory(category);

        return new CreatedAtRouteResult("GetCategory", new { id = category.Id }, category);
    }

    [HttpPut("{id:Guid}")] // Verificar, não encontra ID
    public async Task<ActionResult> Put(Guid id, [FromBody] CategoryModel category) {
        if (id != category.Id) return BadRequest("Categoria não encontrada.");

        if (category is null) return BadRequest("Categoria não encontrada.");

        await _categoryService.UpdateCategory(category);

        return Ok(category);
    }

    [HttpDelete("{id:Guid}")]
    public async Task<ActionResult<CategoryModel>> Delete(Guid id) {
        var category = await _categoryService.GetCategoryById(id);

        if (category is null) return NotFound("Categoria não encontrada.");

        await _categoryService.DeleteCategory(id);

        return Ok(category);
    }
}
