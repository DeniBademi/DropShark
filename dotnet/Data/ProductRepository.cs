using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet.Entities;
using dotnet.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        public void Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
        }

    }
}