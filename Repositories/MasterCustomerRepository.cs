using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace AplikasiBarbershop.Repositories
{
    public class MasterCustomerRepository : InterfaceCrud<MasterCustomerTable>
    {
        private readonly BarberDbContext _dbContext;
        private readonly ResponseResult _result = new ResponseResult();
        public MasterCustomerRepository(BarberDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public MasterCustomerTable Create(MasterCustomerTable model)
        {
            throw new NotImplementedException();
        }

        public MasterCustomerTable Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseResult> ReadAll()
        {
            List<GetCustomerViewModel> data = new List<GetCustomerViewModel>();
            try
            {
                data = await _dbContext.MasterCustomers
                    .Include(o => o.Services)
                    .Include(o => o.Team)
                    .Where(o => o.IsDeleted == false)
                    .Select(o => new GetCustomerViewModel
                    {
                        Id = o.Id,
                        Name = o.Name,
                        Email = o.Email,
                        Phone = o.Phone,
                        Address = o.Address,
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
                GetCustomerViewModel? data = new GetCustomerViewModel();
                data = await _dbContext.MasterCustomers
                    .Include(o => o.Team)
                    .Include(o => o.Services)
                    .Where(o => o.Id == id && o.IsDeleted == false)
                    .Select(o => new GetCustomerViewModel 
                    {
                        Id = o.Id,
                        Name = o.Name,
                        Email = o.Email,
                        Phone = o.Phone,
                        Address = o.Address,
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

        public MasterCustomerTable Update(MasterCustomerTable model)
        {
            throw new NotImplementedException();
        }
    }
}
