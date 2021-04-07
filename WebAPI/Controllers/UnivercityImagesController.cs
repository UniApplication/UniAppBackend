using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnivercityImagesController : ControllerBase
    {
        IUnivercityImageService _univercityImageService;
        public UnivercityImagesController(IUnivercityImageService univercityImage)
        {
            _univercityImageService = univercityImage;
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] UnivercityImage UnivercityImage)
        {
            var result = _univercityImageService.Add(file, UnivercityImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyunivercityid")]
        public IActionResult GetById(int univercityId)
        {
            var result = _univercityImageService.GetByUnivercityId(univercityId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _univercityImageService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
