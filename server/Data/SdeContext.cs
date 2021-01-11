using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using Sde3.Models.Sde;

namespace Sde3.Data
{
  public partial class SdeContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public SdeContext(DbContextOptions<SdeContext> options):base(options)
    {
    }

    public SdeContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Sde3.Models.Sde.Parameter>()
              .HasOne(i => i.Extract)
              .WithMany(i => i.Parameters)
              .HasForeignKey(i => i.ExtractId)
              .HasPrincipalKey(i => i.ExtractId);


        this.OnModelBuilding(builder);
    }


    public DbSet<Sde3.Models.Sde.Extract> Extracts
    {
      get;
      set;
    }

    public DbSet<Sde3.Models.Sde.Parameter> Parameters
    {
      get;
      set;
    }
  }
}
