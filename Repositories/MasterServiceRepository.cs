using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.ViewModel;
using Framework.Auth;
using Microsoft.EntityFrameworkCore;

namespace AplikasiBarbershop.Repositories
{
    public class MasterServiceRepository: InterfaceCrud<ServiceViewModel>
    {
        private readonly BarberDbContext _dbContext;
        private readonly ResponseResult _result = new ResponseResult();
        public MasterServiceRepository(BarberDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public async Task<ResponseResult> Create(ServiceViewModel model)
        {
            try
            {
                MasterServicesTable result = new MasterServicesTable()
                {
                    ServicesName = model.ServicesName,
                    Description = model.Description,
                    ImageUrl = model.ImageUrl,
                    Price = model.Price ?? 0,
                    CreateBy = model.CreateBy,
                    CreateDate = model.CreateDate
                };
                _dbContext.MasterServices.Add(result);
                _dbContext.SaveChanges();

                if ( result.Id > 0)
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
            throw new NotImplementedException();
        }

        public async Task<ResponseResult> ReadAll()
        {
            try
            {
                List<ServiceViewModel> data = new List<ServiceViewModel>();
                data = await _dbContext.Set<MasterServicesTable>()
                    .Include(o => o.User)
                    .Where(o => o.IsDeleted == false)
                    .Select(o => new ServiceViewModel
                    {
                        Id = o.Id,
                        ImageUrl = o.ImageUrl,
                        CreateBy = o.CreateBy,
                        CreateDate = o.CreateDate,
                        Description = o.Description,
                        Price = o.Price,
                        ServicesName = o.ServicesName,
                        IsDeleted = o.IsDeleted,
                        DeletedBy = o.DeletedBy,
                        DeletedDate = o.DeletedDate,
                        ModifiedBy = o.ModifiedBy,
                        ModifiedDate = o.ModifiedDate,
                    })
                    .ToListAsync();
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
                ServiceViewModel? data = new ServiceViewModel();
                data = await _dbContext.MasterServices
                    .Include(o => o.User)
                    .Where(o => o.Id == id && o.IsDeleted == false)
                    .Select(o => new ServiceViewModel 
                    {
                        Id = o.Id,
                        ImageUrl = o.ImageUrl,
                        CreateBy = o.CreateBy,
                        CreateDate = o.CreateDate,
                        Description = o.Description,
                        Price = o.Price,
                        ServicesName = o.ServicesName,
                        IsDeleted = o.IsDeleted,
                        DeletedBy = o.DeletedBy,
                        DeletedDate = o.DeletedDate,
                        ModifiedBy = o.ModifiedBy,
                        ModifiedDate = o.ModifiedDate,
                    }).FirstOrDefaultAsync();
                if(data == null)
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

        public async Task<ResponseResult> Update(ServiceViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
