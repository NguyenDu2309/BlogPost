using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Models.DTO;
using CodePulse.API.Respositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRespository categoryRespository;
        public CategoriesController(ICategoryRespository categoryRespository)
        {
            this.categoryRespository = categoryRespository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto resquest)
        {
            // ánh xạ DTO -> Domain Model
            var category = new Category
            {
                Name = resquest.Name,
                UrlHandle = resquest.UrlHandle
            };

            await categoryRespository.CreateAsync(category);

            // domain model -> dto
            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };

            return Ok(response);
        }
    }
}
