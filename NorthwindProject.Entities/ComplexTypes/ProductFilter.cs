﻿using System;

namespace NorthwindProject.Entities.ComplexTypes
{
    public class ProductFilter
    {
        public int? CategoryId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        public string ProductName { get; set; }
    }
}