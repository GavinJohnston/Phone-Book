using System.Data.Entity;

namespace PhoneBook
{
    public class EFContext :DbContext
    {
        public DbSet<PhoneBook> Book { get; set; }
        public EFContext(string connection) : base(connection)
        {
        }
    }
}