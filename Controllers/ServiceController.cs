﻿using AplikasiBarbershop.DataModel;
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
    public class ServiceController : ControllerBase
    {
        private readonly MasterServiceRepository _repo;
        private readonly IMemoryCache _memoryCache;
        private const string ListCacheKey = "listServices";
        private const string CacheKey = "services";
        private readonly ILogger<ServiceController> _logger;
        private IValidator<ServiceViewModel> _validator;
        public ServiceController(IValidator<ServiceViewModel> validator, BarberDbContext dbContext, IMemoryCache memoryCache, ILogger<ServiceController> logger)
        {
            _repo = new MasterServiceRepository(dbContext);
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
            return res.Success ? Ok(res) : NotFound(res);
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
        public async Task<IActionResult> Create(CreateServiceViewModel model)
        {
            ServiceViewModel input = new ServiceViewModel()
            {
                ServicesName = model.ServicesName,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Price = model.Price ?? 0,
                CreateBy = ClaimContext.UserName(),
                CreateDate = DateTime.Now
            };
            ValidationResult resultVal = await _validator.ValidateAsync(input);
            if (!resultVal.IsValid)
            {
                return BadRequest(resultVal);
            }
            else
            {
                var result = await _repo.Create(input);
                return Ok(result);
            }
        }
    }
}
