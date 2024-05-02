using LXP.Common.ViewModels;
using LXP.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LXP.Common.Entities;
using LXP.Common;
using LXP.Common.MessageModels;
using LXP.Common.MessageModels;
namespace LXP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryServices categoryServices;
        private readonly ILogger<CategoryController> _logger;
        public CategoryController(CategoryServices categoryServices, ILogger<CategoryController> logger)
        {
            this.categoryServices = categoryServices;
            _logger = logger;
        }
        [HttpPost]
        public IActionResult CreateCategory(CourseCategoryViewModel courseCategoryViewModel)
        {
            try
            {
                if (!categoryServices.AddCategory(courseCategoryViewModel).ExistsStatus)
                {
                    
                    return Ok(categoryServices.AddCategory(courseCategoryViewModel));

                }
                else
                {
                    _logger.LogInformation("Error : Required in services layer");
                    return Ok(categoryServices.AddCategory(courseCategoryViewModel));
                }


            }catch(Exception ex)
            {
                _logger.LogInformation("Error : Required in controller layer");
                return BadRequest(ex.Message);
            }
            
        }
    }
}
