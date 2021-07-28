using System;
using Microsoft.EntityFrameworkCore;
using Web_Assignment_2_To_Dos.Data;

namespace Web_Assignment_2_To_Dos.Data.Context
{
    public class To_DoContext
        :DbContext
    {
        public To_DoContext(DbContextOptions<To_DoContext> options)
            :base(options)
        { }

        public DbSet<To_Do> To_Dos { get; set; }
    }
}
