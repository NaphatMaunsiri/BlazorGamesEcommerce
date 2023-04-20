namespace BlazorGamesEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Resident Evil 4 Remake",
                        Description = "Survival is just the beginning. Six years have passed since the biological disaster in Raccoon City. Leon S. Kennedy, one of the survivors, tracks the president's kidnapped daughter to a secluded European village, where there is something terribly wrong with the locals.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/df/Resident_Evil_4_remake_cover_art.jpg",
                        Price = 55.99m
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Resident Evil 3 Remake",
                        Description = "Jill Valentine is one of the last remaining people in Raccoon City to witness the atrocities Umbrella performed. To stop her, Umbrella unleashes their ultimate secret weapon: Nemesis! Also includes Resident Evil Resistance, a new 1 vs 4 online multiplayer game set in the Resident Evil universe.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/dc/Resident_Evil_3.jpg/220px-Resident_Evil_3.jpg",
                        Price = 34.51m
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Resident Evil 2 Remake",
                        Description = "A deadly virus engulfs the residents of Raccoon City in September of 1998, plunging the city into chaos as flesh eating zombies roam the streets for survivors. An unparalleled adrenaline rush, gripping storyline, and unimaginable horrors await you. Witness the return of Resident Evil 2.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/f/fd/Resident_Evil_2_Remake.jpg/220px-Resident_Evil_2_Remake.jpg",
                        Price = 23.19m
                    }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
