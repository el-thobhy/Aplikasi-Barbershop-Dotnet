using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.ViewModel;
using AplikasiPenghitungGaji.Api.Services;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AplikasiBarbershop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserServices _service;
        private IValidator<RegisterViewModel> _validator;
        private IValidator<LoginViewModel> _validatorLogin;
        private IConfiguration _config;
        public AuthController(BarberDbContext dbContext, IValidator<RegisterViewModel> validator, IValidator<LoginViewModel> validatorLogin, IConfiguration config)
        {
            _service = new UserServices(dbContext);
            _validator = validator;
            _validatorLogin = validatorLogin;
            _config = config;
        }

        [HttpPost("Register")]
        public async Task<RegisterViewModel> Register(RegisterViewModel model)
        {
            ValidationResult resultVal = await _validator.ValidateAsync(model);
            if (!resultVal.IsValid)
            {
                throw new Exception(resultVal.Errors.ToString());
            }
            else
            {
                var result = await _service.Register(model);
                return result;
            }
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            ValidationResult val = await _validatorLogin.ValidateAsync(model);
            if (!val.IsValid)
            {
                return BadRequest(val.Errors);
            }
            else
            {
                ReturnLoginViewModel result = await _service.Login(model);
                if (result.Id != null)
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, result.UserName),
                        new Claim("Name", result.Name),
                        new Claim("Id", result.Id.ToString())
                    };
                    foreach (var i in result.Roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, i.ToString()));
                    }
                    var token = GetToken(claims);
                    result.Token = new JwtSecurityTokenHandler().WriteToken(token);
                    result.Expiration = token.ValidTo;
                    return Ok(result);
                }
                else
                {
                    List<object> resultError = new List<object>
                    {
                        new
                        {
                            propertyName = "Credential",
                            errorMessage = "Credential not match!!"
                        }
                    };
                    return NotFound(resultError);
                }
            }

        }

        private JwtSecurityToken GetToken(List<Claim> claims)
        {
            var authSignInKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Secret"] ?? "None"));
            var token = new JwtSecurityToken(
                issuer: _config["JWT:ValidIssuer"],
                audience: _config["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(Convert.ToDouble(_config["JWT:ExpireDays"])),
                claims: claims,
                signingCredentials: new SigningCredentials(authSignInKey, SecurityAlgorithms.HmacSha256)
            );
            return token;
        }
    }
}
