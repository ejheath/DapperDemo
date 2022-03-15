using System;
using System.Collections.Generic;

namespace DapperDemo
{
    public interface IProductRepository
    {
        IEnumerable<Product>GetAllProducts();
        void CreateProduct(string name, double price, int categoryID);
    }
}
