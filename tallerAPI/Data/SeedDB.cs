using Humanizer;

namespace tallerAPI.Data
{
    public class SeedDb
    {
        private readonly tallerDBContext context;
        private readonly Random random;

        public SeedDb(tallerDBContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Cliente.Any())
            {
                this.AddClient("First Client");
                this.AddClient("Second Client");
                this.AddClient("Third Client");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddClient(string name)
        {
            this.context.Cliente.Add(new Models.Cliente
            {
                Name = name,
                Dna = this.random.Next(1000000, 1999999).ToString()
            });
        }

    }

}