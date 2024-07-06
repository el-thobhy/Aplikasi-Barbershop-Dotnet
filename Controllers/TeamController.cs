using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace AplikasiBarbershop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly MasterTeamRepository _repo;
        private readonly IMemoryCache _memoryCache;
        private const string ListCacheKey = "listTeam";
        private const string CacheKey = "team";
        private readonly ILogger<CustomerController> _logger;
        public TeamController(BarberDbContext dbContext, IMemoryCache memoryCache, ILogger<CustomerController> logger)
        {
            _repo = new MasterTeamRepository(dbContext);
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
                if (res.Success && res.Data != null)
                {
                    _memoryCache.Set(ListCacheKey, res, options);
                    _logger.LogInformation("Data cached for key: {ListCacheKey}", ListCacheKey);
                }
            }
            return res.Success && res.Data != null ? Ok(res) : NotFound();
        }
        [HttpGet("ReadById/{id}")]
        public async Task<IActionResult> ReadById(int id)
        {
            string cacheKey = $"{CacheKey}_{id}";
            var options = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(30))
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(30));
            if (_memoryCache.TryGetValue(cacheKey, out ResponseResult? res))
            {
                _logger.LogInformation("Cache hit for key: {CacheKey}", cacheKey);
            }
            else
            {
                _logger.LogInformation("Cache miss for key: {CacheKey}", cacheKey);
                res = await _repo.ReadById(id);
                if (res.Success && res.Data != null)
                {
                    _memoryCache.Set(cacheKey, res, options);
                    _logger.LogInformation("Data cached for key: {CacheKey}", cacheKey);
                }
            }
            return res.Success && res.Data != null ? Ok(res) : NotFound(res);
        }
    }
}
