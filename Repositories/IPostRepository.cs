using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models.Entities;

namespace api.Repositories
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> Get();
        Task<Post> GetPostById(int id);
        Task<IEnumerable<Post>> GetPostsByUser(int userId);
        Task<IEnumerable<Post>> GetPostPerPage(int page, int limit);
    }
}
