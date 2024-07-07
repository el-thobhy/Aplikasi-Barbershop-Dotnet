using AplikasiBarbershop.DataModel;
using DataModel;
using Framework.Auth;
using Microsoft.EntityFrameworkCore;

namespace AplikasiPenghitungGaji.Api.Repository
{
    public class AuthRepository
    {
        protected readonly BarberDbContext _context;
        public AuthRepository(BarberDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        public async Task<IEnumerable<MasterUserTable>> GetAll()
        {
            return await _context.Set<MasterUserTable>().ToListAsync();
        }

        public async Task<MasterUserTable> Login(string username, string password)
        {
            return await _context.Set<MasterUserTable>()
                .FirstOrDefaultAsync(o => o.UserName == username && o.Password == Encryption.HashSha256(password))
                ?? new MasterUserTable();
        }

        public async Task<MasterUserTable> Register(MasterUserTable user)
        {
            _context.Add(user).State = EntityState.Added;
            return user;
        }
        public async Task<MasterBiodataTable> AddBiodata(MasterBiodataTable biodata)
        {
            _context.Add(biodata).State = EntityState.Added;
            return biodata;
        }
        public async Task<MasterUserTable?> GetUserById(int id)
        {
            return await _context.Set<MasterUserTable>()
                .FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken= default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
        //fungsi dispose untuk clear sampah yang ada, GC itu Garbage Collector
        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
