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
                    .Include(o => o.Customer)
                    .Where(o => o.IsDeleted == false)
                    .Select(o => new GetServiceViewModel
                    {
                        Id = o.Id,
                        ImageUrl = o.ImageUrl,
                        CreateBy = o.CreateBy,
                        CreateDate = o.CreateDate,
                        Customer = new CustomerViewModel
                        {
                            Id = o.Customer.Id,
                            Address = o.Customer.Address,
                            Email = o.Customer.Email,
                            Name = o.Customer.Name,
                            Phone = o.Customer.Phone,
                            CreateBy = o.Customer.CreateBy,
                            CreateDate = o.Customer.CreateDate,
                        },
                        Description = o.Description,
                        Price = o.Price,
                        ServicesName = o.ServicesName,
                        CustomerId = o.Customer.Id,
                        IsDeleted = o.IsDeleted,
                        DeletedBy = o.DeletedBy,
                        DeletedDate = o.DeletedDate,
                        ModifiedBy = o.ModifiedBy,
                        ModifiedDate = o.ModifiedDate,
                    })
                    .ToListAsync();
                _result.Data = data;
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

        public MasterServicesTable Update(MasterServicesTable model)
        {
            throw new NotImplementedException();
        }
    }
}
