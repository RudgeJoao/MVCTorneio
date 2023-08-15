using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MicrosoftMVC.Models;

namespace MicrosoftMVC.Data
{
    public class MicrosoftMVCContext : DbContext
    {
        public MicrosoftMVCContext (DbContextOptions<MicrosoftMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MicrosoftMVC.Models.Lutador> Lutador { get; set; } = default!;
    }
}
