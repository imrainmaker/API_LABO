﻿using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAll();

        public Product? GetById(int id);

        public IEnumerable<Product> GetBySeller(int id);

        public Product? CreateProduct(Product product);


        public Product? UpdateProduct(Product product);


        public bool DeleteProduct(Product product);

    }
}
