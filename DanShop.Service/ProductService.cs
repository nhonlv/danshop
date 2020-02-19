using DanShop.Data.Infratructure;
using DanShop.Data.Repositories;
using DanShop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace DanShop.Service
{
    public interface IProductService
    {
        //Product Add(Product product);
        void Update(Product product);

        Product Delete(int id);

        IEnumerable<Product> GetAll();

        IEnumerable<Product> GetAll(string keyword);

        IEnumerable<Product> GetLastest(int top);

        IEnumerable<Product> GetHotProduct(int top);

        void Save();
    }

    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }

        //public Product Add(Product product)
        //{
        //    var newProduct = _productRepository.Add(product);
        //    _unitOfWork.Commit();
        //    if (!string.IsNullOrEmpty(Product.Tags))
        //    {
        //        string[] tags = Product.Tags.Split(',');

        //    }

        //}

        public Product Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public void Update(Product product)
        {
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<Product> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                return _productRepository.GetMulti(x => x.Name.Contains(keyword));
            }
            else
            {
                return _productRepository.GetAll();
            }
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public IEnumerable<Product> GetLastest(int top)
        {
            return _productRepository.GetMulti(X => X.Status).OrderByDescending(x => x.CreatedDate).Take(top);
        }

        public IEnumerable<Product> GetHotProduct(int top)
        {
            return _productRepository.GetMulti(x => x.Status && x.HotFlag == true).OrderByDescending(x => x.CreatedDate).Take(top);
        }
    }
}