﻿using System.Collections.Generic;
using NorthwindProject.Entities.Abstract;

namespace NorthwindProject.Entities.Concrete.Concrete
{
    public class Category:IEntity
    {
        public Category()
        {
            Products =  new List<Product>();
        }

        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}