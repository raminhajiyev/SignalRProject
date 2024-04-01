using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DTOLayer.HighlightDto;
using SignalR.DTOLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetListHighlight()
        {
            var values = _productService.TGetListAll();
            return Ok(values);
        }

        [HttpGet("ProductWithCategory")]
        public IActionResult ProductWithCategoryName()
        {
            var context = new Context();
            var values = context.Products.Include(x=>x.Category).Select(p => new ResultProductWithCategory
            {
                ProductId=p.ProductId,
                ProductName = p.ProductName,
                Description = p.Description,
                Price = p.Price,
                ImageUrl = p.ImageUrl,
                ProductStatus = p.ProductStatus,
                CategoryName = p.Category.CategoryName

            });
            return Ok(values.ToList());
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            Product product = new Product()
            {
               Description = createProductDto.Description,
               ImageUrl= createProductDto.ImageUrl,
               Price = createProductDto.Price,
               ProductName = createProductDto.ProductName,
               ProductStatus = createProductDto.ProductStatus,
               CategoryId=createProductDto.CategoryId
            };
            _productService.TAdd(product);
            return Ok("Data has been successfully added");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Data has been successfully removed");
        }
        [HttpPut]
        public IActionResult UpdateHighlight(UpdateProductDto updateProductDto)
        {
            Product product = new Product()
            {
                ProductId= updateProductDto.ProductId,
                CategoryId = updateProductDto.CategoryId,
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                ProductName = updateProductDto.ProductName,
                ProductStatus = updateProductDto.ProductStatus
            };
            _productService.TUpdate(product);
            return Ok("Data has been updated successfully");
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdProduct(int id)
        {
            var value = _productService.TGetByID(id);

            return Ok(value);
        }
    }
}
