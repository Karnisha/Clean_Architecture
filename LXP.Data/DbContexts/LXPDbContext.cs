using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXP.Data.DbContexts
{
    public class LXPDbContext : DbContext
    {
        public LXPDbContext(DbContextOptions<LXPDbContext> options) : base(options)
        {
        }


    }
}
