﻿using DanShop.Data.Infratructure;
using DanShop.Model.Models;

namespace DanShop.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
             
        }
    }
}