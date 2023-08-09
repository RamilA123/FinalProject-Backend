﻿using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.Include(m => m.Category).
                                     Include(m => m.Discount).
                                     Include(m => m.Brand).
                                     Include(m => m.Rating).
                                     Include(m => m.ProductImages).
                                     Include(m => m.ProductTags).
                                     Include(m => m.Reviews).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            return await _context.Products.Include(m => m.Category).
                                     Include(m => m.Discount).
                                     Include(m => m.Brand).
                                     Include(m => m.Rating).
                                     Include(m => m.ProductImages).
                                     Include(m => m.ProductTags).
                                     Include(m => m.Reviews).FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
