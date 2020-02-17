namespace DanShop.Data.Infratructure
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private DanShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public DanShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}