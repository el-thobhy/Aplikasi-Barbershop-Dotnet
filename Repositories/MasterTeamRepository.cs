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
                    .Include(o => o.Biodata)
                    .Where(o => o.IsDeleted == false)
                    .Select(o => new GetTeamViewModel 
                    { 
                        Id = o.Id,
                        BiodataId = o.BiodataId,
                        Email = o.Email,
                        Name = o.Name,
                        Phone = o.Phone,
                        Role = o.Role,
                        Status = o.Status,
                        Biodata = new BiodataViewModel
                        {
                            Id = o.Biodata.Id,
                            Address = o.Biodata.Address,
                            Email = o.Biodata.Email,
                            Name = o.Biodata.Name,
                            Phone = o.Biodata.Phone,
                            CreateBy = o.Biodata.CreateBy,
                            CreateDate = o.Biodata.CreateDate,
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
                    .Include(o => o.Biodata)
                    .Where(o => o.Id == id && o.IsDeleted == false)
                    .Select(o => new GetTeamViewModel
                    {
                        Id = o.Id,
                        BiodataId = o.BiodataId,
                        Email = o.Email,
                        Name = o.Name,
                        Phone = o.Phone,
                        Role = o.Role,
                        Status = o.Status,
                        Biodata = new BiodataViewModel
                        {
                            Id = o.Biodata.Id,
                            Address = o.Biodata.Address,
                            Email = o.Biodata.Email,
                            Name = o.Biodata.Name,
                            Phone = o.Biodata.Phone,
                            CreateBy = o.Biodata.CreateBy,
                            CreateDate = o.Biodata.CreateDate,
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
