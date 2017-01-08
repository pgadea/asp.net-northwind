using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1.Abstract;
using ClassLibrary1.Concrete.Managers;
using NorthwindProject.DataAccess.Concrete.EntityFramework;
using NorthwindProject.Entities.ComplexTypes;
using NorthwindProject.MvcWebUI.Models;

namespace NorthwindProject.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Product
        public int PageSize = 10;
        public ActionResult Index(int? categoryId, int page = 1)
        {
            var products = _productService.GetAll(new ProductFilter
            {
                CategoryId = categoryId,
                Page = page,
                PageSize = PageSize
            });
            return View(new ProductListViewModel
            {
                Products = products
                //,
                //PagingInfo = new PagingInfo
                //{
                //    CurrentPage = page,
                //    CurrentCategory = categoryId,
                //    Total
                //}
            });
        }
    }
}