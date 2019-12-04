using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace pome.Data
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Models.Product> Products { get;set;}
    }
}