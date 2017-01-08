using System.Collections.Generic;
using NorthwindProject.Entities.Concrete.Concrete;

namespace NorthwindProject.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int? CurrentCategory { get; set; }
    }
}