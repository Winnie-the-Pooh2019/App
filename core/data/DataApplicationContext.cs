using System;
using App.core.data.models;
using Microsoft.EntityFrameworkCore;

namespace App.core.data;

public class DataApplicationContext : DbContext {
    public DbSet<Excavator> excavators { get; private set; }
    public DbSet<WindSpeed> windSpeeds { get; private set; }
    public DbSet<DustEfficiency> dustEfficiencies { get; private set; }
    public DbSet<GroundTypes> groundTypes { get; private set; }
    public DbSet<Humidity> humidities { get; private set; }
    public DbSet<UnitDustExcavator> unitDustExcavators { get; private set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ivan;Username=ivan;Password=1234");
    }
}