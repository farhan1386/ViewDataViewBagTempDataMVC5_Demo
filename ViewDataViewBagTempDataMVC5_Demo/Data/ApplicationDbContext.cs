using System.Data.Entity;
using ViewDataViewBagTempDataMVC5_Demo.Models;

namespace ViewDataViewBagTempDataMVC5_Demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("EmployeeDB")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}