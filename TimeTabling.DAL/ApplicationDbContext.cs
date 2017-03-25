using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TimeTabling.CORE;

namespace TimeTabling.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        
        /// <summary>
        /// Entidad lista de asignaturas persistentes que se generan automaticamente para la BBDD
        /// </summary>
        public DbSet<Subject> SubjectList { get; set; }
        /// <summary>
        /// Entidad lista de detalles por asignatura persistentes que se generan automaticamente para la BBDD
        /// </summary>
        public DbSet<SubjectDetails> SubjectDetailsList { get; set; }

    }

}
