
using Microsoft.EntityFrameworkCore;
using ProductMS.Models;

namespace ProductMS.Data
{
    public class ProductDBCon:DbContext {
        public ProductDBCon(DbContextOptions<ProductDBCon> options) :base(options){

        }
        public DbSet<Product> Products { get; set; }




    }
}
