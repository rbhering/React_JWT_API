using api.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Repositories
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> GetCommentsByPostId(int id);
    }
}
