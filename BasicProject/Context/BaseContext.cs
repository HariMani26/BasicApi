using BasicProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicProject.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions options)
           : base(options)
        {

        }
        public DbSet<UserModel> User { get; set; }

    }
}
