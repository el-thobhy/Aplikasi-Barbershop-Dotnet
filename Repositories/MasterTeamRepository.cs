using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace AplikasiBarbershop.Repositories
{
    public class MasterTeamRepository : InterfaceCrud<MasterTeamTable>
    {
        private readonly BarberDbContext _dbContext;
        private readonly ResponseResult _result = new ResponseResult();
        public MasterTeamRepository(BarberDbContext dbContext)
        {

            _dbContext = dbContext; 

        }
        public MasterTeamTable Create(MasterTeamTable model)
        {
            throw new NotImplementedException();
        }

        public MasterTeamTable Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseResult> ReadAll()
        {
            try
            {
                List<GetTeamViewModel> res = new();
                res = _dbContext.MasterTeams
                    .Include(o => o.Customer)
                    .Where(o => o.IsDeleted == false)
                    .Select(o => new GetTeamViewModel 
                    { 
                        Id = o.Id,
                        CustomerId = o.CustomerId,
                        Email = o.Email,
                        Name = o.Name,
                        Phone = o.Phone,
                        Role = o.Role,
                        Status = o.Status,
                        Customer = new CustomerViewModel
                        {
                            Id = o.Customer.Id,
                            Address = o.Customer.Address,
                            Email = o.Customer.Email,
                            Name = o.Customer.Name,
                            Phone = o.Customer.Phone,
                            CreateBy = o.Customer.CreateBy,
                            CreateDate = o.Customer.CreateDate,
                        }
                    })
                    .ToList();
                if (res == null)
                {
                    _result.Message = "Data tidak Ditemukan";
                    _result.Success = false;
                }
                else
                {
                    _result.Data = res;
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
                GetTeamViewModel? data = new GetTeamViewModel();
                data = await _dbContext.MasterTeams
                    .Include(o => o.Customer)
                    .Where(o => o.Id == id && o.IsDeleted == false)
                    .Select(o => new GetTeamViewModel
                    {
                        Id = o.Id,
                        CustomerId = o.CustomerId,
                        Email = o.Email,
                        Name = o.Name,
                        Phone = o.Phone,
                        Role = o.Role,
                        Status = o.Status,
                        Customer = new CustomerViewModel
                        {
                            Id = o.Customer.Id,
                            Address = o.Customer.Address,
                            Email = o.Customer.Email,
                            Name = o.Customer.Name,
                            Phone = o.Customer.Phone,
                            CreateBy = o.Customer.CreateBy,
                            CreateDate = o.Customer.CreateDate,
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

        public MasterTeamTable Update(MasterTeamTable model)
        {
            throw new NotImplementedException();
        }
    }
}
