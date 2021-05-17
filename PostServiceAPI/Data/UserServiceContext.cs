using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PostServiceAPI.Entites;

namespace PostServiceAPI.Data
{
   

        public class PostServiceContext : DbContext
        {
            public PostServiceContext(DbContextOptions<PostServiceContext> options)
                : base(options)
            {
            }

            public DbSet<Post> Post { get; set; }
            public DbSet<PostUser> User { get; set; }
  
    }
}