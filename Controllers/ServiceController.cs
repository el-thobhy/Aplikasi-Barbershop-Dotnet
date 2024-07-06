using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace AplikasiBarbershop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly MasterServiceRepository _repo;
        private readonly IMemoryCache _memoryCache;
        private const string ListCacheKey = "listServices";
        private readonly ILogger<CustomerController> _logger;
        public ServiceController(BarberDbContext dbContext, IMemoryCache memoryCache, ILogger<CustomerController> logger)
        {
            _repo = new MasterServiceRepository(dbContext);
            _memoryCache = memoryCache;
            _logger = logger;

        }

        [HttpGet("ReadAll")]
        public async Task<IActionResult> ReadAll()
        {

            var options = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(30))
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(30));
            if (_memoryCache.TryGetValue(ListCacheKey, out ResponseResult? res))
            {
                _logger.LogInformation("Cache hit for key: {ListCacheKey}", ListCacheKey);
            }
            else
            {
                _logger.LogInformation("Cache miss for key: {ListCacheKey}", ListCacheKey);
                res = await _repo.ReadAll();
                if (res.Success)
                {
                    _memoryCache.Set(ListCacheKey, res, options);
                    _logger.LogInformation("Data cached for key: {ListCacheKey}", ListCacheKey);
                }
            }
            return res.Success ? Ok(res) : NotFound(res);
        }
    }
}
