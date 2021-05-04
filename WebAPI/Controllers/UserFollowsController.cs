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
    public class UserFollowsController : ControllerBase
    {
        IUserFollowService _userfollowService;
        public UserFollowsController(IUserFollowService userFollowService)
        {
            _userfollowService = userFollowService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userfollowService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getusersfollowingunivercities")]
        public IActionResult GetUsersFollowingUnivercities(int userId)
        {
            var result = _userfollowService.getUsersFollowingUnivercities(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _userfollowService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("checkifuserfollows")]
        public IActionResult CheckIfUserFollowing(UserFollow userFollow)
        {
            var result = _userfollowService.getUserFollowing(userFollow);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(UserFollow userFollow)
        {
            var result = _userfollowService.Add(userFollow);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(UserFollow userFollow)
        {
            var result = _userfollowService.Update(userFollow);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(UserFollow userFollow)
        {
            var result = _userfollowService.Delete(userFollow);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
