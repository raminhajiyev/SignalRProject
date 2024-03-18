using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.ReservationDto;
using SignalR.DTOLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult GetListTestimonial()
        {
            var values = _testimonialService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            Testimonial testimonial = new Testimonial()
            {
                Comment = createTestimonialDto.Comment,
                Title = createTestimonialDto.Title,
                Fullname = createTestimonialDto.Fullname,
                ImageUrl = createTestimonialDto.ImageUrl,
                Status = createTestimonialDto.Status
            };
            _testimonialService.TAdd(testimonial);
            return Ok("Data has been added successfully");
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            Testimonial testimonial = new Testimonial()
            {
                TestimonialId=updateTestimonialDto.TestimonialId,
                Comment = updateTestimonialDto.Comment,
                Title = updateTestimonialDto.Title,
                Fullname = updateTestimonialDto.Fullname,
                ImageUrl = updateTestimonialDto.ImageUrl,
                Status = updateTestimonialDto.Status
            };
            _testimonialService.TUpdate(testimonial);
            return Ok("Data has been updated successfully");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Data has been deleted successfully");
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);

            return Ok(value);
        }
    }
}
