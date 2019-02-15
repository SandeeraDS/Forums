﻿using Forums.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forums.Data
{
    public interface IPost
    {

        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetPostsByForum(int id);

        Task AddAsync(Post post);
        Task Delete(int id);
        Task EditPostContent(int id,string newContent);
       
    }
}
