using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Jijie_Valentin_ProiectF1.Models;

namespace Jijie_Valentin_ProiectF1.Data
{
    public class Jijie_Valentin_ProiectF1Context : DbContext
    {
        public Jijie_Valentin_ProiectF1Context (DbContextOptions<Jijie_Valentin_ProiectF1Context> options)
            : base(options)
        {
        }

        public DbSet<Jijie_Valentin_ProiectF1.Models.Race> Race { get; set; } = default!;
        public DbSet<Jijie_Valentin_ProiectF1.Models.Season> Season { get; set; } = default!;
        public DbSet<Jijie_Valentin_ProiectF1.Models.Team> Team { get; set; } = default!;
        public DbSet<Jijie_Valentin_ProiectF1.Models.Driver> Driver { get; set; } = default!;
        public DbSet<Jijie_Valentin_ProiectF1.Models.Result> Result { get; set; } = default!;
    }
}
