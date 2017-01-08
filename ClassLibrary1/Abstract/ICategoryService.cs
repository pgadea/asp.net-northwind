using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindProject.Entities.Concrete.Concrete;

namespace ClassLibrary1.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
