﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Forums.Data.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Forum Form { get; set; }

        public IEnumerable<PostReply> Replies { get; set; }
    }
}