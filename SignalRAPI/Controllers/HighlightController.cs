using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.DiscountDto;
using SignalR.DTOLayer.HighlightDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighlightController : ControllerBase
    {
        private readonly IHighlightService _highlightService;

        public HighlightController(IHighlightService highlightService)
        {
            _highlightService = highlightService;
        }
        [HttpGet]
        public IActionResult GetListHighlight()
        {
            var values = _highlightService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateHighlight(CreateHighlightDto createHighlightDto)
        {
            Highlight highlight = new Highlight()
            {
                Description1 = createHighlightDto.Description1,
                Description2 = createHighlightDto.Description2,
                Description3 = createHighlightDto.Description3,
                Title1 = createHighlightDto.Title1,
                Title2 = createHighlightDto.Title2,
                Title3 = createHighlightDto.Title3
            };
            _highlightService.TAdd(highlight);
            return Ok("Data has been successfully added");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteHighlight(int id)
        {
            var value = _highlightService.TGetByID(id);  
            _highlightService.TDelete(value);
            return Ok("Data has been successfully removed");
        }
        [HttpPut]
        public IActionResult UpdateHighlight(UpdateHighlightDto updateHighlightDto)
        {
            Highlight highlight = new Highlight()
            {
                HighlightId=updateHighlightDto.HighlightId,
                Description1 = updateHighlightDto.Description1,
                Description2 = updateHighlightDto.Description2,
                Description3 = updateHighlightDto.Description3,
                Title1 = updateHighlightDto.Title1,
                Title2 = updateHighlightDto.Title2,
                Title3 = updateHighlightDto.Title3
            };
            _highlightService.TUpdate(highlight);
            return Ok("Data has been updated successfully");
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdHighlight(int id)
        {
            var value = _highlightService.TGetByID(id);

            return Ok(value);
        }
    }
}
