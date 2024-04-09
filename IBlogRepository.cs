using FinalProject.Models;
using System.Collections.Generic;

namespace FinalProject
{
    public interface IBlogRepository
    {
        // Method to Insert the blog post into Database
        public void InsertBlog(Blog blogToInsert);

       // public void Createblog(blog blogToInsert);

        // Method to retrieve a single blog post by ID
        public Blog GetBlogById(int id);

        // Method to list all blog posts (optional)
        public IEnumerable<Blog> GetAllBlog();

        // Method to creating a new blog post
        

        // Method to update an existing blog post
        public void UpdateBlog(Blog blog);

        // Method to delete an existing blog post
        public void DeleteBlog(int blog);
    }
}
