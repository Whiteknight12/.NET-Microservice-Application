using MicroServiceApplication.Models;

namespace MicroServiceApplication.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly ApplicationDbContext _db;

        public PlatformRepo(ApplicationDbContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
        
        public void CreatePlatform(Platform platform)
        {
            if (platform == null)
            {
                throw new ArgumentNullException(nameof(platform), "Platform cannot be null.");
            }
            _db.Platforms.Add(platform);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _db.Platforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return _db.Platforms.FirstOrDefault(p => p.Id == id) 
                   ?? throw new KeyNotFoundException($"Platform with ID {id} not found.");
        }

        public bool SaveChanges()
        {
            return _db.SaveChanges() >= 0;
        }
    }
}
