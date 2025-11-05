using Microsoft.EntityFrameworkCore;
using EmpresaApi.Models;

namespace EmpresaApi.Data
{
    public class EmpresaDbContext : DbContext
    {
        public EmpresaDbContext(DbContextOptions<EmpresaDbContext> options)
            : base(options)
using Microsoft.EntityFrameworkCore;
using EmpresaApi.Models;

namespace EmpresaApi.Data
{
    public class EmpresaDbContext : DbContext
    {
        public EmpresaDbContext(DbContextOptions<EmpresaDbContext> options)
            : base(options)
        {
        }

 
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        
        
    }
}

