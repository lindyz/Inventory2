﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory2.Models;

namespace Inventory2.Logic
{
    public class AddProducts
    {
        public bool AddProduct(string ProductName, string ProductDesc, string ProductPrice, string ProductCategory, string ProductImagePath)
        {
            //product description
            var myProduct = new Product();
            myProduct.ProductName = ProductName;
            myProduct.Description = ProductDesc;
            myProduct.UnitPrice = Convert.ToDouble(ProductPrice);
            myProduct.ImagePath = ProductImagePath;
            myProduct.CategoryID = Convert.ToInt32(ProductCategory);

            using (ProductContext _db = new ProductContext())
            {
                // Add product to DB.
                _db.Products.Add(myProduct);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}