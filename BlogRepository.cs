using Dapper;
using FinalProject.Models;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data;

namespace FinalProject
{
    public class BlogRepository : IBlogRepository
    {
        private readonly IDbConnection _conn;

        // Configure the database provider and connection string
        public BlogRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        // Method to create a new blog post
        public void InsertBlog(Blog blogToInsert)
        {
            _conn.Execute("INSERT INTO blog (PostId, PostTitle, PostContent, PostAuthor) VALUES (@id, @Title, @Content, @Author);",
             new
            {
                 id = blogToInsert.PostId,
                Title = blogToInsert.PostTitle,
                Content = blogToInsert.PostContent,
                Author = blogToInsert.PostAuthor,
                
            });
        }

        IEnumerable<Blog> IBlogRepository.GetAllBlog()
        {
            var blog = "SELECT * FROM blog";
            return _conn.Query<Blog>(blog).AsList();
        }

        // Method to retrieve blog post by ID
        public Blog GetBlogById(int id)
        {
            var blog = "SELECT * FROM blog WHERE PostId = @id";
            var post = _conn.QuerySingle<Blog>(blog, new { id = id });

            if (post == null)
            {
                // Throw an exception or handle the empty sequence gracefully
                throw new Exception("Blog post with ID " + id + " not found.");
            }

            return post;
        }

        // Method to update a blog post
        public void UpdateBlog(Blog blog)
        {
            _conn.Execute("UPDATE blog SET PostTitle = @Title, PostAuthor =  @Author,  PostContent = @Content WHERE PostId = @id",
             new
             {
                 id = blog.PostId,
                 Title = blog.PostTitle,
                 Content = blog.PostContent,
                 Author = blog.PostAuthor
             });
        }

        // Method to delete a blog post
        public void DeleteBlog(int id)
        {
            var blog = "DELETE FROM blog WHERE PostId = @id";
            _conn.Execute(blog, new { id });
            
        }
        

        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

     
    }
}

