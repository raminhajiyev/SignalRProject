using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.AboutDto;
using SignalR.DTOLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AllListAbout()
        {
            var values = _mapper.Map<List<ResultAboutDto>>(_aboutService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            _aboutService.TAdd(new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImageUrl = createAboutDto.ImageUrl
            });
            return Ok("Data has been added successfully");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetByID(id);
            _aboutService.TDelete(values);
            return Ok("Data has been removed successfully");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            _aboutService.TUpdate(new About()
            {
                AboutId = updateAboutDto.AboutId,
                ImageUrl = updateAboutDto.ImageUrl,
                Description = updateAboutDto.Description,
                Title = updateAboutDto.Title
               
            });
            return Ok("Data has been updated successfully");
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdAbout(int id)
        {
            var value=_aboutService.TGetByID(id);
            return Ok(value);
        }
    }
}
