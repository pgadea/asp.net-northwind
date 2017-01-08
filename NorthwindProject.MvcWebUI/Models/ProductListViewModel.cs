namespace NorthwindProject.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public object PagingInfo { get; set; }
        public System.Collections.Generic.List<NorthwindProject.Entities.Concrete.Product> Products { get; set; }
    }
}