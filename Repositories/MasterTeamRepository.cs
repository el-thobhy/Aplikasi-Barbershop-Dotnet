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
                _result.Data = res;
            }
            catch (Exception e)
            {
                _result.Success = false;
                _result.Message = e.Message;
            }
            return _result;
        }

        public ResponseResult ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public MasterTeamTable Update(MasterTeamTable model)
        {
            throw new NotImplementedException();
        }
    }
}
