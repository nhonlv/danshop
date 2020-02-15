namespace DanShop.Data.Infratructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private DanShopDbContext dbContext;

        public DanShopDbContext Init()
        {
            return dbContext ?? (dbContext = new DanShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}