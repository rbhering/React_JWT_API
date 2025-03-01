using System;
using System.Collections;
using System.Collections.Generic;

namespace api.Models.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Titulo { get; set; }
        public string Text { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }

    }
}
