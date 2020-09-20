using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Data
{
    public class HRSystemContext : DbContext
    {
        private IConfiguration _configuration;
        public HRSystemContext(IConfiguration configuration)
        {
            _configuration =  configuration; 
        }
        public DbSet<Candidate> Candidate{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
    }
}
