using ProductMicroServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroServices.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int ProductId);

        void InsertProduct(Product product);
        void DeleteProduct(int product);
        void UpdateProduct(Product product);
        void Save();


    }
}
