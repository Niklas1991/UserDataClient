using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserDataClient.Models;

namespace UserDataClient.Data
{
    public class UserDataContext : DbContext
    {
        public UserDataContext (DbContextOptions<UserDataContext> options)
            : base(options)
        {
        }

        public DbSet<UserDataClient.Models.Account> Account { get; set; }
    }
}
