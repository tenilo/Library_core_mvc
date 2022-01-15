﻿using Projet.ASP.NET.Core.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _appDbContext.Categories;
        }

        public Category GetCategoryById(int id)
        {
            return _appDbContext.Categories.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
