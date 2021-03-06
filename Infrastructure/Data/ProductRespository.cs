using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRespository : IProductRepository
    {
        private readonly StoreContext _context;
        public ProductRespository(StoreContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Product>> GetProductAsync()
        {
           return await _context.Products.ToListAsync();    
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
           return await _context.Products.FindAsync(id);
        }
    }
}