using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.ContactDto;
using SignalR.DTOLayer.DiscountDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        public IActionResult GetListDiscount()
        {
            var values = _discountService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            Discount discount = new Discount()
            {
               Amount=createDiscountDto.Amount,
               Description=createDiscountDto.Description,
               ImageUrl=createDiscountDto.ImageUrl,
               Title = createDiscountDto.Title
            };
            _discountService.TAdd(discount);
            return Ok("Data has been successfully added");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("Data has been successfully removed");
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            Discount discount = new Discount()
            {
               DiscountId = updateDiscountDto.DiscountId,
                Amount = updateDiscountDto.Amount,
                Description = updateDiscountDto.Description,
                ImageUrl = updateDiscountDto.ImageUrl,
                Title = updateDiscountDto.Title
            };
            _discountService.TUpdate(discount);
            return Ok("Data has been updated successfully");
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdDiscount(int id)
        {
            var value = _discountService.TGetByID(id);

            return Ok(value);
        }
    }
}
