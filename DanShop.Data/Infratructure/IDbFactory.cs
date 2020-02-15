using System;

namespace DanShop.Data.Infratructure
{
    public interface IDbFactory : IDisposable
    {
        DanShopDbContext Init();
    }
}