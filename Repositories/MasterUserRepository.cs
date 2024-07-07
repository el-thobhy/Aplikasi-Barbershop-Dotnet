using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace AplikasiBarbershop.Repositories
{
    public class MasterUserRepository : InterfaceCrud<MasterUserTable>
    {
        private readonly BarberDbContext _dbContext;
        private readonly ResponseResult _result = new ResponseResult();
        public MasterUserRepository(BarberDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public MasterUserTable Create(MasterUserTable model)
        {
            throw new NotImplementedException();
        }

        public MasterUserTable Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseResult> ReadAll()
        {
            List<GetUserViewModel> data = new List<GetUserViewModel>();
            try
            {
                data = await _dbContext.MasterUsers
                    .Include(o => o.Services)
                    .Include(o => o.Team)
                    .Where(o => o.IsDeleted == false)
                    .Select(o => new GetUserViewModel
                    {
                        Id = o.Id,
                        Name = o.Biodata.Name,
                        Email = o.Biodata.Email,
                        Phone = o.Biodata.Phone,
                        Address = o.Biodata.Address,
                        UserName = o.UserName,
                        CreateBy = o.CreateBy,
                        CreateDate = o.CreateDate,
                        DeletedBy = o.DeletedBy,
                        DeletedDate = o.DeletedDate,
                        ModifiedBy = o.ModifiedBy,
                        ModifiedDate = o.ModifiedDate,
                        IsDeleted = o.IsDeleted,
                        Services = o.Services.Select(s => new ServiceViewModel
                        {
                            Id = s.Id,
                            Description = s.Description,
                            ImageUrl = s.ImageUrl,
                            Price = s.Price,
                            ServicesName = s.ServicesName
                        }).ToList(),
                        Team = new TeamViewModel
                        {
                            Id = o.Team.Id,
                            Email = o.Team.Email,
                            Name = o.Team.Name,
                            Phone = o.Team.Phone,
                            Role = o.Team.Role,
                            Status = o.Team.Status
                        }
                    }).ToListAsync();
                if (data == null)
                {
                    _result.Message = "Data tidak Ditemukan";
                    _result.Success = false;
                }
                else
                {
                    _result.Data = data;
                    _result.Message = "Berhasil Get Data";
                }
            }
            catch (Exception e)
            {
                _result.Success = false;
                _result.Message = e.Message;
            }
            return _result;
        }

        public async Task<ResponseResult> ReadById(int id)
        {
            try
            {
                GetUserViewModel? data = new GetUserViewModel();
                data = await _dbContext.MasterUsers
                    .Include(o => o.Team)
                    .Include(o => o.Services)
                    .Where(o => o.Id == id && o.IsDeleted == false)
                    .Select(o => new GetUserViewModel 
                    {
                        Id = o.Id,
                        Name = o.Biodata.Name,
                        Email = o.Biodata.Email,
                        Phone = o.Biodata.Phone,
                        Address = o.Biodata.Address,
                        CreateBy = o.CreateBy,
                        UserName = o.UserName,
                        CreateDate = o.CreateDate,
                        DeletedBy = o.DeletedBy,
                        DeletedDate = o.DeletedDate,
                        ModifiedBy = o.ModifiedBy,
                        ModifiedDate = o.ModifiedDate,
                        IsDeleted = o.IsDeleted,
                        Services = o.Services.Select(s => new ServiceViewModel
                        {
                            Id = s.Id,
                            Description = s.Description,
                            ImageUrl = s.ImageUrl,
                            Price = s.Price,
                            ServicesName = s.ServicesName
                        }).ToList(),
                        Team = new TeamViewModel
                        {
                            Id = o.Team.Id,
                            Email = o.Team.Email,
                            Name = o.Team.Name,
                            Phone = o.Team.Phone,
                            Role = o.Team.Role,
                            Status = o.Team.Status
                        }
                    }).FirstOrDefaultAsync();
                if (data == null)
                {
                    _result.Message = "Data tidak Ditemukan";
                    _result.Success = false;
                }
                else
                {
                    _result.Data = data;
                    _result.Message = "Berhasil Get Data";
                }
            }
            catch (Exception e)
            {
                _result.Success = false;
                _result.Message = e.Message;
            }
            return _result;
        }

        public MasterUserTable Update(MasterUserTable model)
        {
            throw new NotImplementedException();
        }
    }
}
