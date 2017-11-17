using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using  AngularJS4.Models;
using Data.Models;
using Repository.Interface;

namespace AngularJS4.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
        
            return View();
        }
        [HttpGet]
        public IActionResult GetProducts()
        {

            var products = _productRepository.GetAll();
           
            return Json(products);
        }

        [HttpPost]
        public IActionResult AddProducts(ProductModel  productModel)
        {
            Product product =new Product()
            {
                ProductID = productModel.ProductId,
                ProductName = productModel.ProductName
            };
            _productRepository.Add(product);
            return Json("Success");
        }
    }
}