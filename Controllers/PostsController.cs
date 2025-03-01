using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models.Entities;
using api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _postRepository;

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;   
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _postRepository.Get());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _postRepository.GetPostById(id));
        }

        [HttpGet("PostByUser/{userId}")]
        public async Task<IActionResult> GetPostByUser(int userId)
        {
            return Ok(await _postRepository.GetPostsByUser(userId));
        }


    }
}
