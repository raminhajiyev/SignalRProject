using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.ProductDto;
using SignalR.DTOLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        [HttpGet]
        public IActionResult GetListSocialMedia()
        {
            var values = _socialMediaService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            SocialMedia  social= new SocialMedia()
            {
               Title = createSocialMediaDto.Title,
               Url = createSocialMediaDto.Url
            };
            _socialMediaService.TAdd(social);
            return Ok("Data has been successfully added");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("Data has been successfully removed");
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            SocialMedia social = new SocialMedia()
            {
               SocialMediaId = updateSocialMediaDto.SocialMediaId,
                Title = updateSocialMediaDto.Title,
                Url = updateSocialMediaDto.Url
            };
            _socialMediaService.TUpdate(social);
            return Ok("Data has been updated successfully");
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);

            return Ok(value);
        }
    }
}
