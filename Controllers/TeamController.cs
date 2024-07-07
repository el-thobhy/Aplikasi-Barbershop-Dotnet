using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.Repositories;
using AplikasiBarbershop.ViewModel;
using FluentValidation;
using FluentValidation.Results;
using Framework.Auth;
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
        private readonly ILogger<TeamController> _logger;
        private IValidator<InputTeamViewModel> _validator;
        public TeamController(IValidator<InputTeamViewModel> validator, BarberDbContext dbContext, IMemoryCache memoryCache, ILogger<TeamController> logger)
        {
            _repo = new MasterTeamRepository(dbContext);
            _memoryCache = memoryCache;
            _logger = logger;
            _validator = validator;
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
        [HttpPost("Create")]
        [ReadableBodyStream(Roles = "ADMIN")]
        public async Task<IActionResult> Create(InputTeamViewModel model)
        {
            
            ValidationResult resultVal = await _validator.ValidateAsync(model);
            if (!resultVal.IsValid)
            {
                return BadRequest(resultVal);
            }
            else
            {
                TeamViewModel input = new()
                {
                    Email = model.Email,
                    Name = model.Name,
                    Phone = model.Phone,
                    Role = model.Role,
                    Status = model.Status,
                    CreateBy = ClaimContext.UserName(),
                    CreateDate = DateTime.Now
                };
                var result = await _repo.Create(input);
                return Ok(result);
            }
        }

        [HttpPut("Update")]
        [ReadableBodyStream(Roles = "ADMIN")]
        public async Task<IActionResult> Update(UpdateTeamViewModel model)
        {
            ValidationResult resultVal = await _validator.ValidateAsync(model);
            if (!resultVal.IsValid)
            {
                return BadRequest(resultVal.Errors);
            }
            else
            {
                TeamViewModel input = new()
                {
                    Id = model.Id,
                    Email = model.Email,
                    Name = model.Name,
                    Phone = model.Phone,
                    Role = model.Role,
                    Status = model.Status,
                };
                var result = await _repo.Update(input);
                if (result.Success)
                {
                    string cacheKey = $"{CacheKey}_{input.Id}";
                    _memoryCache.Remove(cacheKey);
                    _memoryCache.Remove(ListCacheKey);
                    _logger.LogInformation("Cache removed for key: {CacheKey}", cacheKey);
                }
                return Ok(result);
            }
        }


        [HttpDelete("Delete/{id}")]
        [ReadableBodyStream(Roles = "ADMIN")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _repo.Delete(id); 
            if (result.Success)
            {
                string cacheKey = $"{CacheKey}_{id}";
                _memoryCache.Remove(cacheKey);
                _memoryCache.Remove(ListCacheKey);
                _logger.LogInformation("Cache removed for key: {CacheKey}", cacheKey);
            }
            return result.Success ? Ok(result) : NotFound();
        }
    }
}
