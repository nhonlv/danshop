using DanShop.Data.Infratructure;
using DanShop.Data.Repositories;
using DanShop.Model.Models;
using DanShop.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace DanShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object,  _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory(){ID = 1, Name = "DM1", Status = true},
                new PostCategory(){ID = 2, Name = "DM2", Status = true},
                new PostCategory(){ID = 3, Name = "DM3", Status = true},
            };

        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            _mockRepository.Setup(m=>m.GetAll(null)).Returns(_listCategory);
        }

        [TestMethod] 
        public void PostCategory_Service_Create()
        {
        }
    }
}