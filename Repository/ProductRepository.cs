using Data.Models;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace Repository
{
    public class ProductRepository : Repository<Product> ,IProductRepository
    {
        public ProductRepository(AppDbContext _entities) : base(_entities)
        {
        }

    }
}
