using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.ViewModel;
using Framework.Auth;
using Microsoft.EntityFrameworkCore;

namespace AplikasiBarbershop.Repositories
{
    public class MasterTeamRepository : InterfaceCrud<TeamViewModel>
    {
        private readonly BarberDbContext _dbContext;
        private readonly ResponseResult _result = new ResponseResult();
        public MasterTeamRepository(BarberDbContext dbContext)
        {

            _dbContext = dbContext; 

        }
        public async Task<ResponseResult> Create(TeamViewModel model)
        {
            try
            {
                MasterTeamTable result = new MasterTeamTable()
                {
                    Email = model.Email,
                    Name = model.Name,
                    Phone = model.Phone,
                    Role = model.Role ?? Role.HAIR_STYLIST_MEN,
                    Status = model.Status ?? Status.AVAILABLE,
                    CreateBy = model.CreateBy,
                    CreateDate = model.CreateDate
                };
                _dbContext.MasterTeams.Add(result);
                _dbContext.SaveChanges();

                if (result.Id > 0)
                {
                    ResponseResult respon = ReadById(result.Id).Result;
                    _result.Data = respon.Data;
                    _result.Message = "berhasil create data";
                }
            }
            catch (Exception e)
            {
                _result.Success = false;
                _result.Message = e.Message;
            }

            return _result;
        }

        public async Task<ResponseResult> Delete(int id)
        {
            try
            {
                MasterTeamTable? data = await _dbContext.MasterTeams
                    .Where(o => o.Id == id)
                    .FirstOrDefaultAsync();
                data.IsDeleted = true;
                data.DeletedBy = ClaimContext.UserName();
                data.DeletedDate = DateTime.Now;

                _dbContext.MasterTeams.Update(data);
                _dbContext.SaveChanges();

                
                if (data.IsDeleted == true)
                {
                    _result.Success = true;
                    _result.Message = $"Data {data.Name} berhasil dihapus";
                }
                else
                {
                    _result.Success = false;
                    _result.Message = "data Gagal dihapus";
                }
            }
            catch (Exception e)
            {
                _result.Success = false;
                _result.Message = e.Message;
            }
            return _result;
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
                        CreateBy = o.CreateBy,
                        CreateDate = o.CreateDate,
                        DeletedBy = o.DeletedBy,
                        DeletedDate = o.DeletedDate,
                        IsDeleted = o.IsDeleted,
                        ModifiedBy = o.ModifiedBy,
                        ModifiedDate = o.ModifiedDate,
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
                        CreateBy = o.CreateBy,
                        CreateDate = o.CreateDate,
                        DeletedBy = o.DeletedBy,
                        DeletedDate = o.DeletedDate,
                        IsDeleted = o.IsDeleted,
                        ModifiedBy = o.ModifiedBy,
                        ModifiedDate = o.ModifiedDate,
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

        public async Task<ResponseResult> Update(TeamViewModel model)
        {
            try
            {

                MasterTeamTable? result = await _dbContext.MasterTeams
                    .Where(o => o.Id == model.Id && o.IsDeleted == false)
                    .FirstOrDefaultAsync();

                if (result != null)
                {
                    result.Name = model.Name;
                    result.Email = model.Email;
                    result.Status = model.Status ?? 0;
                    result.Phone = model.Phone;
                    result.Role = model.Role ?? 0;
                    result.CreateBy = result.CreateBy;
                    result.CreateDate = result.CreateDate;
                    result.ModifiedBy = ClaimContext.UserName();
                    result.ModifiedDate = DateTime.Now;

                    _dbContext.SaveChanges();

                    ResponseResult respon = ReadById(result.Id).Result;
                    _result.Success = true;
                    _result.Data = respon.Data;
                    _result.Message = "berhasil update data";
                }

            }
            catch (Exception e)
            {
                _result.Success = false;
                _result.Message = e.Message;
            }

            return _result;
        }
    }
}
