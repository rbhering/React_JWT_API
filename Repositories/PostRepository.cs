using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Post>> Get()
        {
            return await _context.Post.ToListAsync();
        }

        public async Task<Post> GetPostById(int id)
        {
            return await _context.Post.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Post>> GetPostsByUser(int userId)
        {
            return await _context.Post.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
