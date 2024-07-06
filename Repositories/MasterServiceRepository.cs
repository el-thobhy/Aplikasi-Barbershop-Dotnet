using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace AplikasiBarbershop.Repositories
{
    public class MasterServiceRepository: InterfaceCrud<MasterServicesTable>
    {
        private readonly BarberDbContext _dbContext;
        private readonly ResponseResult _result = new ResponseResult();
        public MasterServiceRepository(BarberDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public MasterServicesTable Create(MasterServicesTable model)
        {
            throw new NotImplementedException();
        }

        public MasterServicesTable Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseResult> ReadAll()
        {
            try
            {
                List<GetServiceViewModel> data = new List<GetServiceViewModel>();
                data = await _dbContext.Set<MasterServicesTable>()
                    .Include(o => o.Biodata)
                    .Where(o => o.IsDeleted == false)
                    .Select(o => new GetServiceViewModel
                    {
                        Id = o.Id,
                        ImageUrl = o.ImageUrl,
                        CreateBy = o.CreateBy,
                        CreateDate = o.CreateDate,
                        Biodata = new BiodataViewModel
                        {
                            Id = o.Biodata.Id,
                            Address = o.Biodata.Address,
                            Email = o.Biodata.Email,
                            Name = o.Biodata.Name,
                            Phone = o.Biodata.Phone,
                            CreateBy = o.Biodata.CreateBy,
                            CreateDate = o.Biodata.CreateDate,
                        },
                        Description = o.Description,
                        Price = o.Price,
                        ServicesName = o.ServicesName,
                        BiodataId = o.Biodata.Id,
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
                GetServiceViewModel? data = new GetServiceViewModel();
                data = await _dbContext.MasterServices
                    .Include(o => o.Biodata)
                    .Where(o => o.Id == id && o.IsDeleted == false)
                    .Select(o => new GetServiceViewModel 
                    {
                        Id = o.Id,
                        ImageUrl = o.ImageUrl,
                        CreateBy = o.CreateBy,
                        CreateDate = o.CreateDate,
                        Biodata = new BiodataViewModel
                        {
                            Id = o.Biodata.Id,
                            Address = o.Biodata.Address,
                            Email = o.Biodata.Email,
                            Name = o.Biodata.Name,
                            Phone = o.Biodata.Phone,
                            CreateBy = o.Biodata.CreateBy,
                            CreateDate = o.Biodata.CreateDate,
                        },
                        Description = o.Description,
                        Price = o.Price,
                        ServicesName = o.ServicesName,
                        BiodataId = o.Biodata.Id,
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

        public MasterServicesTable Update(MasterServicesTable model)
        {
            throw new NotImplementedException();
        }
    }
}
