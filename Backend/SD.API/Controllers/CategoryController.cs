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
    public ActionResult<List<CategoryModel>> GetCategories() {
        var categories = _categoryService.GetAllCategories();
        return Ok(categories);
    }

    [HttpPost]
    public ActionResult<CategoryModel> PostCategory(CategoryModel category) {
        _categoryService.CreateCategory(category);
        return Ok(category);
    }
}
