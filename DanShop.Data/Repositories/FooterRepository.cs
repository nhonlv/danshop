using DanShop.Data.Infratructure;
using DanShop.Model.Models;

namespace DanShop.Data.Repositories
{
    public interface IFooterRepository
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}