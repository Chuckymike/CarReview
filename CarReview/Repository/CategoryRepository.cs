﻿using CarReview.Models;
using CarReview.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarReview.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        private CarBlogContext db;
        public CategoryRepository(CarBlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories;
        }

        public Category GetById(int id)
        {
            return db.Categories.SingleOrDefault(c => c.CategoryId == id);
        }

        public int Count()
        {
            return db.Categories.Count();
        }

        public void Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Update(Category category)
        {
            db.Categories.Update(category);
            db.SaveChanges();
        }

        public void Create(Content content)
        {
            throw new NotImplementedException();
        }

        public void Update(Content content)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
