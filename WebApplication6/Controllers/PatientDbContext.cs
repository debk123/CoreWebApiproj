using Microsoft.EntityFrameworkCore;
namespace WebApplication6.Controllers
{
    public class PatientDbContext:DbContext
    {
        public PatientDbContext(DbContextOptions<PatientDbContext> opt):base(opt)
        {

        }
        public DbSet<patient> Patients { get; set; }
    }
}
