using MailKit.Search;
using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.ProductDetail;

namespace OrganiDb.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> FilterByCategoryAsync(int? id)
        {
            return await _context.Products.Where(m => m.CategoryId == id).Include(m => m.Category).
                                     Include(m => m.Discount).
                                     Include(m => m.Brand).
                                     Include(m => m.Rating).
                                     Include(m => m.ProductImages).
                                     Include(m => m.ProductTags).
                                     Include(m => m.Reviews).ToListAsync();
        }

        public async Task<IEnumerable<Product>> FilterByPriceAsync(string minumumValue, string maximumValue)
        {
            List<Product> filteredProducts = new List<Product>();
            
            IEnumerable<Product> products = await GetAllAsync();

            foreach (Product product in products)
            {
              if (product.Discount.Percent == 0)
              {
                 if (product.ActualPrice >= Decimal.Parse(minumumValue) && product.ActualPrice <= Decimal.Parse(maximumValue))
                 {
                        filteredProducts.Add(product);
                 }
              }

              else
              {
                    if (product.ActualPrice - (product.ActualPrice * product.Discount.Percent) / 100 >= Decimal.Parse(minumumValue) 
                    && product.ActualPrice - (product.ActualPrice * product.Discount.Percent) / 100 <= Decimal.Parse(maximumValue))
                    {
                        filteredProducts.Add(product);
                    }
              }

            }

            return filteredProducts;
        }

        public async Task<IEnumerable<Product>> FilterByRatingAsync(int? id)
        {
            return await _context.Products.Where(m => m.RatingId == id).Include(m => m.Category).
                                     Include(m => m.Discount).
                                     Include(m => m.Brand).
                                     Include(m => m.Rating).
                                     Include(m => m.ProductImages).
                                     Include(m => m.ProductTags).
                                     Include(m => m.Reviews).ToListAsync();
        }

        public async Task<IEnumerable<Product>> FilterByTagAsync(int? id)
        {
            List<Product> products = new List<Product>();

            IEnumerable<Product> dbProducts = await GetAllAsync();

            foreach (Product product in dbProducts) 
            {
                foreach (ProductTag productTag in product.ProductTags)
                {
                    if(productTag.TagId == id)
                    {
                        products.Add(product);
                    }
                }
            }

            return products;
        }

        public async Task<IEnumerable<Product>> FilterByBrandAsync(int? id)
        {
            return await _context.Products.Where(m => m.BrandId == id).Include(m => m.Category).
                                    Include(m => m.Discount).
                                    Include(m => m.Brand).
                                    Include(m => m.Rating).
                                    Include(m => m.ProductImages).
                                    Include(m => m.ProductTags).
                                    Include(m => m.Reviews).ToListAsync();
        }

        public async Task<IEnumerable<Product>> SortByDescendingPriceAsync()
        {
            IEnumerable<Product> products = await GetAllAsync();

            products = products.OrderByDescending(m => m.ActualPrice).ToList();

            return products;
        }

        public async Task<IEnumerable<Product>> SortByAscendingPriceAsync()
        {
            IEnumerable<Product> products = await GetAllAsync();

            products = products.OrderBy(m => m.ActualPrice).ToList();

            return products;
        }

        public async Task<IEnumerable<Product>> SortByAscendingNameAsync()
        {
            IEnumerable<Product> products = await GetAllAsync();

            products = products.OrderBy(m => m.Name).ToList();

            return products;
        }

        public async Task<IEnumerable<Product>> SortByDescendingNameAsync()
        {
            IEnumerable<Product> products = await GetAllAsync();

            products = products.OrderByDescending(m => m.Name).ToList();

            return products;
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

        public async Task<Product> GetByIdWithImagesAsync(int? id)
        {
            return await _context.Products.Include(m => m.ProductImages).Include(m => m.Discount).FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Products.CountAsync();
        }

        public async Task<IEnumerable<Product>> GetPaginatedDatasAsync(int page, int take)
        {
            return await _context.Products.Include(m => m.Category).
                                     Include(m => m.Discount).
                                     Include(m => m.Brand).
                                     Include(m => m.Rating).
                                     Include(m => m.ProductImages).
                                     Include(m => m.ProductTags).
                                     Include(m => m.Reviews).Skip((page - 1) * take).Take(take).ToListAsync();
        }

        public async Task<IEnumerable<Product>> SearchByProductsAsync(string searchText)
        {
            IEnumerable<Product> products = await GetAllAsync();

            products = products.Where(m => m.Name.ToLower().Contains(searchText.ToLower())).ToList();

            return products;
        }

    }
}
