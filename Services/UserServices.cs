using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.ViewModel;
using AplikasiPenghitungGaji.Api.Repository;
using Framework.Auth;

namespace AplikasiPenghitungGaji.Api.Services
{
    public class UserServices
    {
        private readonly AuthRepository _userRepository;
        private readonly BarberDbContext _dbContext;
        public UserServices(BarberDbContext dbContext)
        {
            _userRepository = new AuthRepository(dbContext);
            _dbContext = dbContext;

        }

        public Task<IEnumerable<RegisterViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ReturnLoginViewModel> Login(LoginViewModel login)
        {
           ReturnLoginViewModel? model = (from o in _dbContext.MasterUsers
                                        where o.UserName == login.UserName && o.Password == Encryption.HashSha256(login.Password)
                                        select new ReturnLoginViewModel
                                        {
                                            UserName = o.UserName,
                                            Name = o.Biodata.Name,
                                            Id = o.Id,
                                            Roles = new List<string>
                                            {
                                                o.Role.ToString(),
                                            }
                                        }
                                        ).FirstOrDefault();
            return model ?? new ReturnLoginViewModel();
        }

        public async Task<RegisterViewModel> Register(RegisterViewModel user)
        {
            RegisterViewModel? output = new RegisterViewModel();
            MasterBiodataTable biodata = new MasterBiodataTable()
            {
                Address = user.Address,
                Phone = user.Phone,
                Email = user.Email,
                Name = user.Name,
                CreateBy = "admin",
                CreateDate = DateTime.Now,
            };
            await _userRepository.AddBiodata(biodata);
            var resultBio = await _userRepository.SaveChangeAsync();
            MasterUserTable entity = new MasterUserTable();
            if (resultBio > 0)
            {
                entity = new MasterUserTable
                {
                    UserName = user.UserName,
                    Password = Encryption.HashSha256(user.Password),
                    Role = user.Role,
                    BiodataId = biodata.Id,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                };
            }
            await _userRepository.Register(entity);
            var result = await _userRepository.SaveChangeAsync();
            if (result > 0)
            {
                output = (from o in _dbContext.MasterUsers
                          where o.Id == entity.Id
                          select new RegisterViewModel
                          {
                              UserName = o.UserName,
                              Password = o.Password,
                              Phone = o.Biodata.Phone,
                              Address = o.Biodata.Address,
                              Email = o.Biodata.Email,
                              Name = o.Biodata.Name,
                              Role = o.Role,
                              Id = o.Id
                          }).FirstOrDefault();
            }
            return output ?? new RegisterViewModel();
        }
    }
}
