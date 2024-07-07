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
                List<TeamViewModel> res = new();
                res = _dbContext.MasterTeams
                    .Where(o => o.IsDeleted == false)
                    .Select(o => new TeamViewModel 
                    { 
                        Id = o.Id,
                        Email = o.Email,
                        Name = o.Name,
                        Phone = o.Phone,
                        Role = o.Role,
                        Status = o.Status,
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
                TeamViewModel? data = new TeamViewModel();
                data = await _dbContext.MasterTeams
                    .Include(o => o.User)
                    .Where(o => o.Id == id && o.IsDeleted == false)
                    .Select(o => new TeamViewModel
                    {
                        Id = o.Id,
                        Email = o.Email,
                        Name = o.Name,
                        Phone = o.Phone,
                        Role = o.Role,
                        Status = o.Status,
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
