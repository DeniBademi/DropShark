using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet.Entities;

namespace dotnet.Interfaces
{
    public interface IProductRepository
    {
        void Update(Product product);
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
    }
}