﻿using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllWithIncludesAsync();
    }
}