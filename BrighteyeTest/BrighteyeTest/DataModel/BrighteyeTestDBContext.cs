using System.Data.Entity;

namespace BrighteyeTest
{
    public class BrighteyeTestDBContext : DbContext
    {
        public BrighteyeTestDBContext()
            : base("name=BrighteyeTestDBContext")
        {
        }

        public DbSet<SortedNumber> SortedNumbers { get; set; }
        public DbSet<UnsortedNumber> UnsortedNumbers { get; set; }
    }
}