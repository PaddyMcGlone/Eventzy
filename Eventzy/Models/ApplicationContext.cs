using System;
using Microsoft.EntityFrameworkCore;

namespace Eventzy.Models
{
    public class ApplicationContext: DbContext
    {
        #region Constructor
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        #endregion

        #region Properties

        public DbSet<Event> Events { get; set; }

        #endregion
    }
}
